using Microsoft.AspNetCore.Mvc;
using Shop.Microservice.Core.Models;
using Shop.Microservice.Domain.Entities;
using Shop.Microservice.Infrastructure.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.Microservice.Core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrdersController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var orders = await _orderService.GetAllOrdersAsync();
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var order = await _orderService.GetOrderByIdAsync(id);
            if (order == null) return NotFound();
            return Ok(order);
        }
        [HttpGet("cart")]
        public async Task<IActionResult> GetCart([FromQuery]Guid userid)
        {
            var order = await _orderService.GetCart(userid);
            if (order == null) return NotFound();

            return Ok(order);
        }
        [HttpPost("cart")]
        public async Task<IActionResult> PutToCart([FromBody] UserCartModel model)
        {
            var order = await _orderService.PutToCart(model.Userid, model.Productid);
            if (order == null) return NotFound();
            return Ok(order);
        }

        [HttpPost("ordercart")]
        public async Task<IActionResult> OrderCart([FromBody] string orderid)
        {
           await _orderService.OrderCart(Guid.Parse(orderid));
            
            return Ok();
        }

        [HttpPost("removeorderproduct")]
        public async Task<IActionResult> OrderCart([FromBody] OrderCartModel orderproduct)
        {
            await _orderService.RemoveOrderProduct(orderproduct.OrderId, orderproduct.Productid);

            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Order order)
        {
            var createdOrder = await _orderService.CreateOrderAsync(order);
            return CreatedAtAction(nameof(Get), new { id = createdOrder.Id }, createdOrder);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Order order)
        {
            if (id != order.Id) return BadRequest();

            await _orderService.UpdateOrderAsync(order);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _orderService.DeleteOrderAsync(id);
            return NoContent();
        }
    }
}
