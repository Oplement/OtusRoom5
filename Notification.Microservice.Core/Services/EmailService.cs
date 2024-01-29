using Microsoft.Extensions.Options;
using MimeKit;
using MailKit.Net.Smtp;
using Notification.Microservice.Core.Interfaces;
using Notification.Microservice.Core.Settings;

namespace Notification.Microservice.Core.Services
{
    public class EmailService : IEmailService
    {


        public void Send(string toName, string toEmail, string subject, string text, string fromName,string fromEmail)
        {

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(fromName, fromEmail));
                message.To.Add(new MailboxAddress(toName, toEmail));
                message.Subject = subject;

                message.Body = new TextPart("plain")
                {
                    Text = text
                };

                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 465, true);

                    // Note: only needed if the SMTP server requires authentication
                    client.Authenticate("nik.glazkov2016@gmail.com", "jkwu vszn akah bjww");

                    client.Send(message);
                    client.Disconnect(true);
                }
        }
    }    
}
