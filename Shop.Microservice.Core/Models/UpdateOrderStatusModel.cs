namespace Shop.Microservice.Core.Models
{
    public class UpdateOrderStatusModel
    {
        public Guid Id { get; set; }
        public string Status { get; set; }

        public UpdateOrderStatusModel( Guid id, string status)
        {
            Id = id;
            Status = status;
        }
    }
}
