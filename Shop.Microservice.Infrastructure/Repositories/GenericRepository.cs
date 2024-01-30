using Shop.Microservice.Domain.Entities;
using Shop.Microservice.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Shop.Microservice.Infrastructure.Repositories.Contracts;

namespace Shop.Microservice.Infrastructure.Repositories.Implementation
{
    public class GenericRepository<T> : IRepository<T>
        where T : class
    {
        private readonly DatabaseContext _databaseContext;
        public GenericRepository(DatabaseContext context)
        {
            _databaseContext = context ?? throw new ArgumentNullException(nameof(context));
        }


        public async Task<T> Create(T item)
        {
            await _databaseContext.AddAsync(item);
            await _databaseContext.SaveChangesAsync();

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
        public async Task<Guid> GetCartOrderByUserId(Guid userid)
        {
            var order = _databaseContext.Orders.Include(m=>m.OrderProducts).FirstOrDefault(m => m.UserId == userid && m.OrderStatus == OrderStatus.InCart);
            var id = new Guid();
            if (order == null)
            {
                var data = new Order() { CreateAt = DateTime.UtcNow, OrderStatus = OrderStatus.InCart, UserId = userid };
                _databaseContext.Orders.Add(data);
                _databaseContext.SaveChanges();
                id = data.Id;
            }
            else
            {
                id = order.Id;
            }

            return id;
        }

        public async Task<Balance> GetBalance(Guid userid)
        {
            var balance = _databaseContext.Balances.FirstOrDefault(m=>m.UserId ==  userid);

            return balance;
        }
        public async Task<List<Order>> GetOrders(Guid userid)
        {
             var orders =_databaseContext.Orders.Include(m => m.OrderProducts).ThenInclude(m=>m.Product).Where(x => x.UserId == userid).ToList();
             



            return orders;
        }
        public async Task<List<OrderProduct>> GetCart(Guid userid)
        {

            var id = await GetCartOrderByUserId(userid);
            var cart = _databaseContext.OrderProducts.Include(m=>m.Product).Where(m => m.OrderId == id).ToList();
            
            return cart;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _databaseContext.Set<T>().ToListAsync();
        }
        public async Task<List<Order>> GetAllOrders()
        {
            var orders = await _databaseContext.Orders.Include(m => m.OrderProducts).ThenInclude(_ => _.Product).ToListAsync();
            return orders;
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

        public async Task<List<OrderProduct>> PutToCart(Guid userid, Guid productid)
        {
            var id = await GetCartOrderByUserId(userid);

            var prod = _databaseContext.OrderProducts.FirstOrDefault(m => m.OrderId == id && m.ProductId == productid);
            if(prod != null)
            {
                prod.Count++;
            }
            else
            {
                _databaseContext.OrderProducts.Add(new OrderProduct() { OrderId = id, Count = 1, ProductId = productid });
            }

            _databaseContext.SaveChanges();

            return _databaseContext.OrderProducts.Where(m => m.Id == id).ToList();
        }

        public async Task OrderCart(Guid orderid)
        {
            var order = _databaseContext.Orders.Include(m=>m.OrderProducts).ThenInclude(m=>m.Product).FirstOrDefault(m => m.Id == orderid);
            order.OrderStatus = OrderStatus.InProgress;


            var sum = 0;

            foreach (var item in order.OrderProducts)
            {
                sum += item.Count * item.Product.Price;
                _databaseContext.Products.FirstOrDefault(m=>m.Id == item.ProductId).Count -= item.Count;
            }
            
            var balance = _databaseContext.Balances.FirstOrDefault(m=>m.UserId == order.UserId);
            balance.Amount -= sum;

            await _databaseContext.SaveChangesAsync();


        }

        public async Task RemoveOrderProduct(Guid orderid, Guid productid)
        {
            var orderProduct = _databaseContext.OrderProducts.FirstOrDefault(m => m.OrderId == orderid && m.ProductId == productid);
            _databaseContext.OrderProducts.Remove(orderProduct);

            await _databaseContext.SaveChangesAsync();
        }
    }
}
