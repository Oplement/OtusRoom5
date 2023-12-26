using Microsoft.AspNetCore.Mvc;
using Shop.Microservice.Domain.Common;
using Shop.Microservice.Infrastructure.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.Microservice.Core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BalancesController : ControllerBase
    {
        private readonly BalanceService _balanceService;

        public BalancesController(BalanceService balanceService)
        {
            _balanceService = balanceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var balances = await _balanceService.GetAllBalancesAsync();
            return Ok(balances);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var balance = await _balanceService.GetBalanceByIdAsync(id);
            if (balance == null) return NotFound();
            return Ok(balance);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Balance balance)
        {
            var createdBalance = await _balanceService.CreateBalanceAsync(balance);
            return CreatedAtAction(nameof(Get), new { id = createdBalance.Id }, createdBalance);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Balance balance)
        {
            if (id != balance.Id) return BadRequest();

            await _balanceService.UpdateBalanceAsync(balance);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _balanceService.DeleteBalanceAsync(id);
            return NoContent();
        }
    }
}
