using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaMinistryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediaMinistryManagement.Controllers
{
    [Route("api/completed_order_counts")]
    public class Completed_Order_CountsController : Controller
    {
        private readonly Completed_Order_CountsContext _context;

        public Completed_Order_CountsController(Completed_Order_CountsContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Completed_Order_Counts>>> GetCustomers()
        {
            return await _context.Completed_Order_Counts.ToListAsync();
        }

        // GET: api/CustomerInfo/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompletedOrderCounts([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var customerInfo = await _context.Completed_Order_Counts.FindAsync(id);

            if (customerInfo == null)
            {
                return NotFound();
            }

            return Ok(customerInfo);
        }

        // POST: api/Orders
        [HttpPost]
        public async Task<IActionResult> PostCompletedOrderCounts([FromBody] Completed_Order_Counts orderItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Completed_Order_Counts.Add(orderItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompletedOrderCounts", new { id = orderItem.order_number }, orderItem);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var orderItem = await _context.Completed_Order_Counts.FindAsync(id);
            if (orderItem == null)
            {
                return NotFound();
            }

            _context.Completed_Order_Counts.Remove(orderItem);
            await _context.SaveChangesAsync();

            return Ok(orderItem);
        }

        private bool OrderItemExists(int id)
        {
            return _context.Completed_Order_Counts.Any(e => e.order_number == id);
        }
    }
}
