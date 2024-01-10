using Shop.Microservice.Domain.Entities;

namespace Shop.Microservice.Domain.Common
{
    public class Product : IEntity
    {
        public Guid Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
    }
}
