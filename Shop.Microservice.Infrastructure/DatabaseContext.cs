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
           
                new Product() { Count = 15, Description = "Размеры S,M,L", Id = Guid.NewGuid(), Price = 5999, Title = "Худи", Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg"},
            
                new Product(){ Count=75, Title = "ПоверБанк", Price = 2399, Description = "10000мАч", Id = Guid.NewGuid(), Image="https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg" },
           
                new Product() { Count = 34, Description = "Отличный подарок", Id = Guid.NewGuid(), Price = 1999, Title = "Термокружка", Image = "https://praktika-reklama.ru/images/stories/virtuemart/product/3146.40_1_tif_1000x1000.jpg"},
            
                new Product(){ Count=75, Title = "Флешка 64gb", Price = 799, Description = "Флешка на 64 гб", Id = Guid.NewGuid(), Image="https://chel.sp-computer.ru/upload/iblock/dd0/dd0d7bdff13a3c31afd2f39080d7f0a2.jpg" },
           
                new Product() { Count = 12, Description = "Овечья шерсть", Id = Guid.NewGuid(), Price = 5999, Title = "Плед красный", Image = "https://paters.ru/files/catalog/o_3545.jpg"},
            
                new Product(){ Count=34, Title = "Рюкзак", Price = 2399, Description = "Хороший рюкзак", Id = Guid.NewGuid(), Image="https://illan-gifts.ru/api/images/riukzak-molti-base-seryj-818385.jpeg" },
                        
                new Product(){ Count=52, Title = "Перчатки", Price = 1199, Description = "Зимние перчатки", Id = Guid.NewGuid(), Image="https://a.allegroimg.com/original/115466/f37055214459bfdcb1252f470363/Rekawice-meskie-polarowe-zimowe-rekawiczki-L-XL" },
           
                new Product() { Count = 21, Description = "Размеры S,M,L", Id = Guid.NewGuid(), Price = 599, Title = "Носки", Image = "https://cdn1.ozone.ru/s3/multimedia-g/6049217164.jpg"},
           
                new Product(){ Count=55, Title = "Футболка", Price = 899, Description = "10000мАч", Id =  Guid.NewGuid(), Image="https://galagraffity.ru/image/cache/catalog/XML341ae4b41effce6e99b3170a951e6dc7/futbolki/IMGec5d5e1c4a114ecba74c0557231a0d43-767x767.jpg" },

                new Product(){ Count=55, Title = "Шарф", Price = 799, Description = "Шарф", Id =  Guid.NewGuid(), Image="https://bis-souvenir.ru/wp-content/uploads/2021/01/6901992-th-img.jpg" },



            };


            var balanceTestUser = new Balance()
            {
                Id= Guid.NewGuid(),
                UserId = Guid.Parse("a2a7dcb7-49fd-4ab9-bd00-b05d31a12d3e"),
                Amount = 10,
                AmountForSend = 100
            };
            var balanceTestUser2 = new Balance()
            {
                Id = Guid.NewGuid(),
                UserId = Guid.Parse("a2a7dcb7-49fd-4ab9-bd00-b05d31a19d3e"),
                Amount = 20,
                AmountForSend = 200
            };
          
            var order = new Order() 
            {Id = Guid.NewGuid(), OrderStatus=OrderStatus.InCart,CreateAt=DateTime.UtcNow,UserId= Guid.Parse("a2a7dcb7-49fd-4ab9-bd00-b05d31a12d3e") };
            var orderProduct = new OrderProduct()
            {Id = Guid.NewGuid(), Count = 1,OrderId=order.Id,ProductId=products.First().Id};

            modelBuilder.Entity<Balance>().HasData(balanceTestUser);
            modelBuilder.Entity<Balance>().HasData(balanceTestUser2);

            modelBuilder.Entity<Product>().HasData(products);
            modelBuilder.Entity<Order>().HasData(order);
            modelBuilder.Entity<OrderProduct>().HasData(orderProduct);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=123123;Database=postgres;Port=5432;");
        }

    }
}
