using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MediaMinistryManagement.Models;

namespace MediaMinistryManagerAPI.Controllers.Listeners
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListenersController : ControllerBase
    {
        private readonly ListenerContext _context;

        public ListenersController(ListenerContext context)
        {
            _context = context;
        }

        // GET: api/Listeners
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Listener>>> GetListeners()
        {
            return await _context.Listeners.ToListAsync();
        }

        // GET: api/Listeners/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Listener>> GetListener(string id)
        {
            var listener = await _context.Listeners.FindAsync(id);

            if (listener == null)
            {
                return NotFound();
            }

            return listener;
        }

        // PUT: api/Listeners/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutListener(string id, Listener listener)
        {
            if (id != listener.EMAIL)
            {
                return BadRequest();
            }

            _context.Entry(listener).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ListenerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Listeners
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Listener>> PostListener(Listener listener)
        {
            _context.Listeners.Add(listener);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ListenerExists(listener.EMAIL))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetListener", new { id = listener.EMAIL }, listener);
        }

        // DELETE: api/Listeners/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Listener>> DeleteListener(string id)
        {
            var listener = await _context.Listeners.FindAsync(id);
            if (listener == null)
            {
                return NotFound();
            }

            _context.Listeners.Remove(listener);
            await _context.SaveChangesAsync();

            return listener;
        }

        private bool ListenerExists(string id)
        {
            return _context.Listeners.Any(e => e.EMAIL == id);
        }
    }
}
