using Notification.Microservice.Core.Interfaces;

namespace Notification.Microservice.Core.Settings
{
    public class LoggingEmailServiceDecorator : EmailServiceDecorator
    {
        public LoggingEmailServiceDecorator(IEmailService emailService) : base(emailService) { }

        public override void Send(string toName, string toEmail, string subject, string text, string fromName, string fromEmail)
        {
            // Логирование перед отправкой письма
            Console.WriteLine($"Sending email to: {toEmail}, Subject: {subject}");

            _innerEmailService.Send(toName, toEmail, subject, text, fromName, fromEmail);

            // Логирование после отправки письма
            Console.WriteLine("Email sent successfully");
        }
    }
}
