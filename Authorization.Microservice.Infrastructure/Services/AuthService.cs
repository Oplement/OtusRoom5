using Authorization.Microservice.Domain;
using Authorization.Microservice.Infrastructure.Repositories.Contracts;

namespace Authorization.Microservice.Infrastructure.Services
{
    public class AuthService
    {
        private readonly IRepository<User> _repository;
        public AuthService(IRepository<User> repository)
        {
            _repository = repository;
        }
        public async Task<User> GetByEmailAsync(string email)
        {
            return await _repository.Get(email);
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            return await _repository.Get(id);
        }

        public async Task<User> CreateAsync(User user)
        {
            return await _repository.Create(user);
        }


    }
}
