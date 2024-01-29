
using System.Transactions;

namespace Shop.Microservice.Domain.Common
{
    public class Transaction : IEntity
    {
        public Guid Id { get; set; }
        public Guid SenderID { get; set; }
        public Guid ReceiverID { get; set; }

        public long Amount { get; set; }
        public string Comment { get; set; }
        public DateTime TimeStamp { get; set; }
    }

}


