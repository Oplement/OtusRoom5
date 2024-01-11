namespace Shop.Microservice.Core.Models
{
    public class CartModel
    {
        public Guid Userid { get; set; }
        public Guid Productid { get; set; }

        public CartModel(Guid userid, Guid productid)
        {
            Userid = userid;
            Productid = productid;
        }
    }
}
