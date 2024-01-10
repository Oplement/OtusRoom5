namespace Shop.Microservice.Domain.Common
{
    public class Balance : IEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public double Amount { get; set; }
        public double AmountForSend { get; set; }
    }
}
