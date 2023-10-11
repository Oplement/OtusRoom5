using Shop.Microservice.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Shop.Microservice.Infrastructure
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Balance> Balances { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }


        public DatabaseContext()
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=12345678;Database=ShopMicroserviceInfrastructure;Port=5480;");
        }

    }
}
