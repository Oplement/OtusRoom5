using Shop.Microservice.Domain.Entities;
using Shop.Microservice.Infrastructure.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Microservice.Infrastructure.Services
{
    public class OrderService
    {
        private readonly IRepository<Order> _repository;

        public OrderService(IRepository<Order> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await _repository.GetAll();
        }

        public async Task<Order> GetOrderByIdAsync(Guid id)
        {
            return await _repository.Get(id);
        }

        public async Task<List<OrderProduct>> GetCart(Guid userid)
        {
            return await _repository.GetCart(userid);
        }
        public async Task<List<OrderProduct>> PutToCart(Guid userid, Guid productid)
        {
            return await _repository.PutToCart(userid, productid);
        }
        public async Task OrderCart(Guid orderid)
        {
            await _repository.OrderCart(orderid);
        }
        public async Task RemoveOrderProduct(Guid orderid, Guid productid)
        {
            await _repository.RemoveOrderProduct(orderid, productid);
        }

        public async Task<Order> CreateOrderAsync(Order order)
        {
            return await _repository.Create(order);
        }

        public async Task UpdateOrderAsync(Order order)
        {
            await _repository.Update(order);
        }

        public async Task DeleteOrderAsync(Guid id)
        {
            await _repository.Delete(id);
        }
    }
}
