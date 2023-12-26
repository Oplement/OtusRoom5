
using System.Transactions;

namespace Shop.Microservice.Domain.Common
{
    public class Transaction : BaseAuditableEntity
    {
        public Guid SenderID { get; set; }
        public long Amount { get; set; }
        public string Comment { get; set; }
        public DateTime TimeStamp { get; set; }
        public TransactionStatus TransactionStatus { get; set; }
    }

}


