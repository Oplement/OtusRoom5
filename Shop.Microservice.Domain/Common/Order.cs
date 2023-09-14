using Authorization.Microservice.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Microservice.Domain.Common
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("User")]
        public Guid UserID { get; set; }
        public List<Product> Producs { get; set; }
        public OrderStatus OrderStatus { get; set; }


        public virtual User User { get; set; }

    }


}
