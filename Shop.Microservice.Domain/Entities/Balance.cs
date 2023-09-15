using Authorization.Microservice.Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Microservice.Domain.Common
{
    public class Balance : BaseAuditableEntity
    {
        public Guid UserID { get; set; }
        public double Amount { get; set; }
        public double AmountForSend { get; set; }
    }
}
