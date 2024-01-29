using Authorization.Microservice.Domain;
using Authorization.Microservice.Infrastructure.Repositories.Contracts;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Text;

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
        public async Task<List<User>> GetUsersByFilter(string filter)
        {
            return await _repository.GetByFilter(filter);
        }
        public async Task<User> GetByIdAsync(Guid id)
        {
            return await _repository.Get(id);
        }

        public async Task<User> CreateAsync(User user)
        {
            return await _repository.Create(user);
        }

        public async Task<string> Hash(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                var hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                return hash;
            }
        }
    }
}
