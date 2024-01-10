using Shop.Microservice.Domain.Common;

namespace Shop.Microservice.Domain.Entities
{
    public class Order : IEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }

        //public List<Product> Products { get; set; }

        public OrderStatus OrderStatus { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
