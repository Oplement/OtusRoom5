using Notification.Microservice.Core.Settings;
using RabbitMQ.Client;
using System.Text.Json;
using System.Text;
using Notification.Microservice.Core.Interfaces;
using RabbitMQ.Client.Events;
using System.Threading.Channels;
using System.Diagnostics;

namespace Notification.Microservice.Core.Services
{
    public class Consumer : BackgroundService
    {
        Channel ch = new Channel();

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {


            stoppingToken.ThrowIfCancellationRequested();

            var consumer = new EventingBasicConsumer(ch._channel);
            consumer.Received += (obj, ea) =>
            {
                var content = JsonSerializer.Deserialize<MessageDto>(Encoding.UTF8.GetString(ea.Body.ToArray()));

                // Обрабатываем полученное сообщение
                EmailService emailService = new EmailService();
                emailService.Send(content.UserName, content.Email, content.Topic, content.Content, "OtusRoom5", "otusroom5@mail.ru");
                //
                ch._channel.BasicAck(ea.DeliveryTag, false);
            };

            ch._channel.BasicConsume(ch._queueName, false, consumer);

            return Task.CompletedTask;

        }

        public override void Dispose()
        {
            ch._channel.Close();
            ch._connection.Close();
            base.Dispose();
        }

    }
}
