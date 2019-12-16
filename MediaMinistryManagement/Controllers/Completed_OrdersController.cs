using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaMinistryManagement.Models.OrdersFolder.OrdersFiles;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediaMinistryManagement.Controllers
{
    [Route("api/completed_orders")]
    public class Completed_OrdersController : Controller
    {
        private readonly Completed_OrdersContext _context;

        public Completed_OrdersController(Completed_OrdersContext context)
        {
            _context = context;
        }

        // GET: api/CustomerInfo/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompleted_Orders([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var customerInfo = await _context.Completed_Orders.FindAsync(id);

            if (customerInfo == null)
            {
                return NotFound();
            }

            return Ok(customerInfo);
        }

        // POST: api/Orders
        [HttpPost]
        public async Task<IActionResult> PostOrderItem([FromBody] Completed_Orders orderItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Completed_Orders.Add(orderItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompleted_Orders", new { id = orderItem.order_number }, orderItem);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var orderItem = await _context.Completed_Orders.FindAsync(id);
            if (orderItem == null)
            {
                return NotFound();
            }

            _context.Completed_Orders.Remove(orderItem);
            await _context.SaveChangesAsync();

            return Ok(orderItem);
        }

        private bool OrderItemExists(int id)
        {
            return _context.Completed_Orders.Any(e => e.order_number == id);
        }
    }
}
