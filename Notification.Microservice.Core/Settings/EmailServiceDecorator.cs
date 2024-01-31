using Notification.Microservice.Core.Interfaces;

namespace Notification.Microservice.Core.Settings
{
    public abstract class EmailServiceDecorator : IEmailService
    {
        protected readonly IEmailService _innerEmailService;

        protected EmailServiceDecorator(IEmailService emailService)
        {
            _innerEmailService = emailService;
        }

        public abstract void Send(string toName, string toEmail, string subject, string text, string fromName, string fromEmail);
    }
}
