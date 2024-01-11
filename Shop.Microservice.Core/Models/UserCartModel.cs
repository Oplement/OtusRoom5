namespace Shop.Microservice.Core.Models
{
    public class UserCartModel
    {
        public Guid Userid { get; set; }
        public Guid Productid { get; set; }

        public UserCartModel(Guid userid, Guid productid)
        {
            Userid = userid;
            Productid = productid;
        }
    }
}
