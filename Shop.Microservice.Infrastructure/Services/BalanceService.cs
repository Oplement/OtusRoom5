using Shop.Microservice.Domain.Common;
using Shop.Microservice.Infrastructure.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Microservice.Infrastructure.Services
{
    public class BalanceService
    {
        private readonly IRepository<Balance> _repository;

        public BalanceService(IRepository<Balance> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Balance>> GetAllBalancesAsync()
        {
            return await _repository.GetAll();
        }

        public async Task<Balance> GetBalanceByIdAsync(Guid id)
        {
            return await _repository.Get(id);
        }

        public async Task<Balance> CreateBalanceAsync(Balance balance)
        {
            return await _repository.Create(balance);
        }

        public async Task UpdateBalanceAsync(Balance balance)
        {
            await _repository.Update(balance);
        }

        public async Task DeleteBalanceAsync(Guid id)
        {
            await _repository.Delete(id);
        }
    }
}
