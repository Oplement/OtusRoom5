using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;

namespace Shop.Microservice.Domain.Common;

public class Transaction : BaseEntity
{
    public Guid SenderID { get; set; }
    public long Amount { get; set; }
    public string Comment { get; set; }
    public DateTime TimeStamp { get; set; }
    public TransactionStatus TransactionStatus { get; set; }
}

