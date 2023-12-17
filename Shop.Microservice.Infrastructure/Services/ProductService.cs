using Shop.Microservice.Domain.Common;
using Shop.Microservice.Infrastructure.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Microservice.Infrastructure.Services
{
    public class ProductService
    {
        private readonly IRepository<Product> _repository;

        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _repository.GetAll();
        }

        public async Task<Product> GetProductByIdAsync(Guid id)
        {
            return await _repository.Get(id);
        }

        public async Task<Product> CreateProductAsync(Product product)
        {
            return await _repository.Create(product);
        }

        public async Task UpdateProductAsync(Product product)
        {
            await _repository.Update(product);
        }

        public async Task DeleteProductAsync(Guid id)
        {
            await _repository.Delete(id);
        }
    }
}
