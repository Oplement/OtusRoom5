using Shop.Microservice.Domain.Entities;
using Shop.Microservice.Domain.Common;

namespace Shop.Microservice.Infrastructure.Repositories.Contracts
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(Guid id);
        Task<T> Create(T item);
        Task Update(T item);
        Task<List<OrderProduct>> GetCart(Guid userid);
        Task Delete(Guid id);
        
        Task Save();
    }
}
