﻿

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;
using Authorization.Microservice.Domain.Entities;

namespace Shop.Microservice.Domain.Common
{
    public class Transaction
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("User")]
        public Guid SenderID { get; set; }

        public long Amount { get; set; }

        public string Comment { get; set; }
        public DateTime TimeStamp { get; set; }
        public TransactionStatus TransactionStatus { get; set; }

        public virtual User User { get; set; }

    }


}
