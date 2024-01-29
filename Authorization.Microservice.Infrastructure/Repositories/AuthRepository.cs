using Authorization.Microservice.Domain;
using Authorization.Microservice.Infrastructure.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Authorization.Microservice.Infrastructure.Repositories.Implementation
{
    public class AuthRepository<T> : IRepository<T>
        where T : class
    {
        DatabaseContext _databaseContext;
        public AuthRepository(DatabaseContext context)
        {
            _databaseContext = context;
        }

        public async Task<T> Create(T item)
        {
            await _databaseContext.AddAsync(item);

            return item;
        }

        public async Task Delete(Guid id)
        {
            var user = await _databaseContext.Set<T>().FindAsync(id);
            if (user == null) return;

            _databaseContext.Set<T>().Remove(user);
        }

        public async Task<T> Get(Guid id)
        {
            return await _databaseContext.Set<T>().FindAsync(id);
        }
        public async Task<User> Get(string email)
        {
            var res = await _databaseContext.Users.FirstOrDefaultAsync(m => m.Email == email);
            return res;
        }
        public async Task<List<User>> GetByFilter(string filter)
        {
            var res = await _databaseContext.Users.Where(m=>m.Username.ToLower().StartsWith(filter)).ToListAsync();
            return res;
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
        }
    }
}
