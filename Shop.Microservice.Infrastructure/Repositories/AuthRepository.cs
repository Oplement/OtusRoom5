using Shop.Microservice.Domain.Entities;
using Shop.Microservice.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Shop.Microservice.Infrastructure.Repositories.Contracts;

namespace Shop.Microservice.Infrastructure.Repositories.Implementation
{
    public class AuthRepository<T> : IRepository<T>
        where T : class
    {
        private readonly DatabaseContext _databaseContext;
        public AuthRepository(DatabaseContext context)
        {
            _databaseContext = context ?? throw new ArgumentNullException(nameof(context));
        }


        public async Task<T> Create(T item)
        {
            await _databaseContext.AddAsync(item);
            return item;
        }

        public async Task Delete(Guid id)
        {
            var entity = await _databaseContext.Set<T>().FindAsync(id);
            if (entity != null)
            {
                _databaseContext.Set<T>().Remove(entity);
            }
        }

        public void Dispose()
        {
            Save().Wait();
        }

        public async Task<T> Get(Guid id)
        {
            return await _databaseContext.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _databaseContext.Set<T>().ToListAsync();
        }

        public async Task Save()
        {
            await _databaseContext.SaveChangesAsync();
        }

        public async Task Update(T item)
        {
            _databaseContext.Set<T>().Update(item);
            await Save();
        }
    }
}
