

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;
using Authorization.Microservice.Domain.Entities;

namespace Shop.Microservice.Domain.Common
{
    public class Order : BaseAuditableEntity
    {
        public Guid UserID { get; set; }
        public List<Product> Producs { get; set; }
        public OrderStatus OrderStatus { get; set; }
    }


}
