using Shop.Microservice.Domain.Entities;
using Shop.Microservice.Domain.Common;

namespace Shop.Microservice.Infrastructure.Repositories.Contracts
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<List<Order>> GetAllOrders();
        Task<T> Get(Guid id);
        Task<Balance> GetBalance(Guid userid);
        Task<List<Order>> GetOrders(Guid userid);
        Task<T> Create(T item);
        Task Update(T item);
        Task UpdatePhoto(Guid id, string path);
        Task UpdateOrderStatus (Guid id, string status);
        Task OrderCart(Guid orderid);
        Task<List<OrderProduct>> GetCart(Guid userid);
        Task<List<OrderProduct>> PutToCart(Guid userid, Guid productid);
        Task RemoveOrderProduct(Guid orderid, Guid productid);
        Task Delete(Guid id);
        
        Task Save();
    }
}
