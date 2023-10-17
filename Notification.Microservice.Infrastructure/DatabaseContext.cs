using Microsoft.EntityFrameworkCore;

namespace Notification.Microservice.Infrastructure
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Domain.Entities.Notification> Notifications { get; set; }

        public DatabaseContext()
        {
            // Database.EnsureDeleted();
            // Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=12345678;Database=NotificationMicroserviceInfrastructure;Port=5480;");
        }
    }
}
