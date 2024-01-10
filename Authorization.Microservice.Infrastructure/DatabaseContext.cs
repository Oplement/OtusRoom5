using Authorization.Microservice.Domain;
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            User user = new User() { Email ="admin@mail.ru", Role = "admin", Username = "admin", PasswordHash = "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918" };
            modelBuilder.Entity<User>().HasData(user);
        }
        public override ValueTask DisposeAsync()
        {
            SaveChanges();
            return base.DisposeAsync();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=otus_glazev_test;Username=postgres;Password=123123");
        }

    }
}
