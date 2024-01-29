namespace Shop.Microservice.Core.Models
{
    public class CreateTransactionModel
    {
        public Guid UserId { get; set; }
        public Guid ReceiverId { get; set; }
        public string Comment { get; set; }
        public string Amount { get; set; }

        public CreateTransactionModel(Guid userid, Guid receiverid, string comment, string amount)
        {
            UserId = userid;
            ReceiverId = receiverid;
            Comment = comment;
            Amount = amount;
        }
    }
}
