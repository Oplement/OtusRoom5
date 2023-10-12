using Shop.Microservice.Domain.Common;
using System.Transactions;

namespace Shop.Microservice.Domain.Entities
{
    public class Transaction : BaseEntity
    {
        public Guid SenderID { get; set; }
        public long Amount { get; set; }
        public string Comment { get; set; }
        public DateTime TimeStamp { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
    }

}


