using Authorization.Microservice.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Authorization.Microservice.Infrastructure
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DatabaseContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=otus_glazev_test;Username=postgres;Password=123123");
        }

    }
}
