using Authorization.Microservice.Domain.Entities;

namespace Authorization.Microservice.Infrastructure.Repositories.Contracts
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(Guid id);
        Task<User> Get(string email);
        Task<T> Create(T item);
        Task Update(T item);
        Task Delete(Guid id);

        Task Save();
    }
}
