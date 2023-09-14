using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authorization.Microservice.Domain;

namespace Shop.Microservice.Domain.Common
{
    public class Balance
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("User")]
        public Guid UserID { get; set; }
        public double Amount { get; set; }
        public double AmountForSend { get; set; }


        public virtual User User { get; set; }

    }
}
