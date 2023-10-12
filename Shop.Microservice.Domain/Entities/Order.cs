using Shop.Microservice.Domain.Common;

namespace Shop.Microservice.Domain.Entities
{
    public class Order : BaseAuditableEntity
    {
        public Guid UserID { get; set; }
        public List<Product> Producs { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }


}
