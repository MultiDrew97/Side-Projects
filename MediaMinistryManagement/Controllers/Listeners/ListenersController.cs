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

        // GET: api/EmailListeners
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmailListener>>> GetEmailListeners()
        {
            return await _context.Email_Listeners.ToListAsync();
        }

        // GET: api/EmailListeners/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmailListener>> GetEmailListener(string id)
        {
            var emailListener = await _context.Email_Listeners.FindAsync(id);

            if (emailListener == null)
            {
                return NotFound();
            }

            return emailListener;
        }

        // PUT: api/EmailListeners/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmailListener(string id, EmailListener emailListener)
        {
            if (id != emailListener.EMAIL)
            {
                return BadRequest();
            }

            _context.Entry(emailListener).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmailListenerExists(id))
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

        // POST: api/EmailListeners
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<EmailListener>> PostEmailListener(EmailListener emailListener)
        {
            _context.Email_Listeners.Add(emailListener);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EmailListenerExists(emailListener.EMAIL))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEmailListener", new { id = emailListener.EMAIL }, emailListener);
        }

        // DELETE: api/EmailListeners/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EmailListener>> DeleteEmailListener(string id)
        {
            var emailListener = await _context.Email_Listeners.FindAsync(id);
            if (emailListener == null)
            {
                return NotFound();
            }

            _context.Email_Listeners.Remove(emailListener);
            await _context.SaveChangesAsync();

            return emailListener;
        }

        private bool EmailListenerExists(string id)
        {
            return _context.Email_Listeners.Any(e => e.EMAIL == id);
        }
    }
}
