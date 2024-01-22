using Shop.Microservice.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Shop.Microservice.Domain.Common;
using Authorization.Microservice.Domain;

namespace Shop.Microservice.Infrastructure
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Balance> Balances { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }


        public DatabaseContext()
        {
     

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var products = new List<Product>() {
            new Product() { Count = 2, Description = "Размеры S,M,L", Id = Guid.NewGuid(), Price = 5999, Title = "Худи", Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg"},
            new Product(){ Count=5, Title = "ПоверБанк", Price = 2399, Description = "10000мАч", Id = Guid.NewGuid(), Image="https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg" },
            new Product() { Count = 2, Description = "Размеры S,M,L", Id = Guid.NewGuid(), Price = 5999, Title = "Худи", Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg"},
            new Product(){ Count=5, Title = "ПоверБанк", Price = 2399, Description = "10000мАч", Id = Guid.NewGuid(), Image="https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg" },
            new Product() { Count = 2, Description = "Размеры S,M,L", Id = Guid.NewGuid(), Price = 5999, Title = "Худи", Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg"},
            new Product(){ Count=5, Title = "ПоверБанк", Price = 2399, Description = "10000мАч", Id = Guid.NewGuid(), Image="https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg" },
            new Product() { Count = 2, Description = "Размеры S,M,L", Id = Guid.NewGuid(), Price = 5999, Title = "Худи", Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg"},
            new Product(){ Count=5, Title = "ПоверБанк", Price = 2399, Description = "10000мАч", Id = Guid.NewGuid(), Image="https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg" },
            new Product() { Count = 2, Description = "Размеры S,M,L", Id = Guid.NewGuid(), Price = 5999, Title = "Худи", Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg"},
            new Product(){ Count=5, Title = "ПоверБанк", Price = 2399, Description = "10000мАч", Id =  Guid.NewGuid(), Image="https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg" },
            };
            
            var order = new Order() 
            {Id = Guid.NewGuid(), OrderStatus=OrderStatus.InCart,CreateAt=DateTime.UtcNow,UserId= Guid.Parse("a2a7dcb7-49fd-4ab9-bd00-b05d31a12d3e") };
            var orderProduct = new OrderProduct()
            {Id = Guid.NewGuid(), Count = 1,OrderId=order.Id,ProductId=products.First().Id};
            

            modelBuilder.Entity<Product>().HasData(products);
            modelBuilder.Entity<Order>().HasData(order);
            modelBuilder.Entity<OrderProduct>().HasData(orderProduct);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.EnableSensitiveDataLogging();
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=123123;Database=postgres;Port=5432;");
        }

    }
}
