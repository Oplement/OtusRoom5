

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;

namespace Shop.Microservice.Domain.Common
{
    public class Product : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
    }
}
