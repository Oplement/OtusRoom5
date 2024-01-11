namespace Shop.Microservice.Core.Models
{
    public class OrderCartModel
    {
        public Guid OrderId { get; set; }
        public Guid Productid { get; set; }

        public OrderCartModel(Guid orderid, Guid productid)
        {
            OrderId = orderid;
            Productid = productid;
        }
    }
}
