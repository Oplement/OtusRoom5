using Authorization.Microservice.Domain;

namespace Authorization.Microservice.Infrastructure.Repositories.Contracts
{
    public interface IRepository<T>
        where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(Guid id);
        Task<List<User>> GetByFilter(string filter);
        Task<User> Get(string email);
        Task<T> Create(T item);
        Task Update(T item);
        Task Delete(Guid id);

        Task Save();
    }
}
