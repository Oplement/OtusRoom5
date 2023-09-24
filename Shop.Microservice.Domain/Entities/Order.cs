using Authorization.Microservice.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Microservice.Domain.Common
{
    public class Order : BaseAuditableEntity
    {
        public Guid UserID { get; set; }
        public List<Product> Producs { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }


}
