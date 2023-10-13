namespace Notification.Microservice.Domain
{
    public class Notification : IEntity
    {
        public Guid UserID { get; set; }
        public string Text { get; set; }
        public DateTime TimeStamp { get; set; }
        public Guid Id { get; set; }
    }
}
