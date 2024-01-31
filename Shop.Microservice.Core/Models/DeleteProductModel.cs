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

    public class UpdatePhotoModel
    {
        public Guid Id { get; set; }
        public string Path { get; set; }
        public UpdatePhotoModel(Guid id, string path)
        {
            Id = id;
            Path = path;
        }
    }
}
