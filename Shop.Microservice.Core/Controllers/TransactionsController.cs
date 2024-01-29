using Microsoft.AspNetCore.Mvc;
using Shop.Microservice.Core.Models;
using Shop.Microservice.Domain.Common;
using Shop.Microservice.Infrastructure.Services;

namespace Shop.Microservice.Core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionsController : ControllerBase
    {
        private readonly TransactionService _transactionService;
        private readonly BalanceService _balanceService;

        public TransactionsController(TransactionService transactionService, BalanceService balanceService)
        {
            _transactionService = transactionService;
            _balanceService = balanceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var transactions = await _transactionService.GetAllTransactionsAsync();
            return Ok(transactions);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var transaction = await _transactionService.GetTransactionByIdAsync(id);
            if (transaction == null) return NotFound();
            return Ok(transaction);
        }

        [HttpPost("post", Name ="post")]
        public async Task<IActionResult> Post([FromBody] CreateTransactionModel data)
        {
            var transaction = new Transaction()
            {
                Amount = Int64.Parse(data.Amount),
                SenderID = data.UserId,
                TimeStamp = DateTime.UtcNow,
                ReceiverID = data.ReceiverId, 
                Comment = data.Comment,
            };


            var receiverBalance = await _balanceService.GetBalance(transaction.ReceiverID);
            receiverBalance.Amount += transaction.Amount;
            await _balanceService.UpdateBalanceAsync(receiverBalance);
            
            var senderBalance = await _balanceService.GetBalance(transaction.SenderID);
            senderBalance.AmountForSend -= transaction.Amount;
            await _balanceService.UpdateBalanceAsync(senderBalance);

            var createdTransaction = await _transactionService.CreateTransactionAsync(transaction);
            return CreatedAtAction(nameof(Get), new { id = createdTransaction.Id }, createdTransaction);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Transaction transaction)
        {
            if (id != transaction.Id) return BadRequest();

            await _transactionService.UpdateTransactionAsync(transaction);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _transactionService.DeleteTransactionAsync(id);
            return NoContent();
        }
    }
}
