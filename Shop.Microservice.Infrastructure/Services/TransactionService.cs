using Shop.Microservice.Domain.Common;
using Shop.Microservice.Infrastructure.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Microservice.Infrastructure.Services
{
    public class TransactionService
    {
        private readonly IRepository<Transaction> _repository;

        public TransactionService(IRepository<Transaction> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Transaction>> GetAllTransactionsAsync()
        {
            return await _repository.GetAll();
        }

        public async Task<Transaction> GetTransactionByIdAsync(Guid id)
        {
            return await _repository.Get(id);
        }

        public async Task<Transaction> CreateTransactionAsync(Transaction transaction)
        {
            return await _repository.Create(transaction);
        }

        public async Task UpdateTransactionAsync(Transaction transaction)
        {
            await _repository.Update(transaction);
        }

        public async Task DeleteTransactionAsync(Guid id)
        {
            await _repository.Delete(id);
        }

       
    }
}
