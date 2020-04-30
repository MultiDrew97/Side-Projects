using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MediaMinistryManagement.Models;

namespace MediaMinistryManagement.Controllers
{
    [Route("api/order_counts")]
    [ApiController]
    public class Order_CountsController : ControllerBase
    {
        private readonly Order_CountsContext _context;

        public Order_CountsController(Order_CountsContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order_Counts>>> GetCustomers()
        {
            return await _context.Order_Counts.ToListAsync();
        }

        // GET: api/CustomerInfo/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderCounts([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var customerInfo = await _context.Order_Counts.FindAsync(id);

            if (customerInfo == null)
            {
                return NotFound();
            }

            return Ok(customerInfo);
        }

        // POST: api/Orders
        [HttpPost]
        public async Task<IActionResult> PostOrderItem([FromBody] Order_Counts orderItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Order_Counts.Add(orderItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrderCounts", new { id = orderItem.order_number }, orderItem);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var orderItem = await _context.Order_Counts.FindAsync(id);
            if (orderItem == null)
            {
                return NotFound();
            }

            _context.Order_Counts.Remove(orderItem);
            await _context.SaveChangesAsync();

            return Ok(orderItem);
        }

        private bool OrderItemExists(int id)
        {
            return _context.Order_Counts.Any(e => e.order_number == id);
        }
    }
}