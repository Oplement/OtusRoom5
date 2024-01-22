namespace Shop.Microservice.Core.Models
{
    public class DeleteProductModel
    {
        public Guid ProductId { get; set; }

        public DeleteProductModel( Guid productid)
        {
            ProductId = productid;
        }
    }
}
