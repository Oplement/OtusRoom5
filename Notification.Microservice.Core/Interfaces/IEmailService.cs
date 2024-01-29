namespace Notification.Microservice.Core.Interfaces
{
    public interface IEmailService
    {
        void Send(string toName, string toEmail, string subject, string text, string fromName, string fromEmail);
    }
}
