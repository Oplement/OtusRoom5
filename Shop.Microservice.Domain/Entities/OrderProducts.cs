using Shop.Microservice.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Microservice.Domain.Entities
{
    public class OrderProduct : IEntity
    {
        public Guid Id { get; set; }

        public Order Order { get; set; }
        public Guid OrderId { get; set; }

        public Product Product { get; set; }
        public Guid ProductId { get; set; }

        public int Count { get; set; }
    }
}
