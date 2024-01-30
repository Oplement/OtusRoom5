using Notification.Microservice.Core;
using RabbitMQ.Client;
using Shop.Microservice.Domain.Common.Interfaces;
using Shop.Microservice.Infrastructure.Services;
using System.Text;
using System.Text.Json;

namespace Shop.Microservice.Core
{
    public class RmqProducer : IProducer
    {
        public void Produce(string messageContent, string topic, string userName, string email)
        {
            Channel ch = new Channel();

            var message = new MessageDto()
            {
                Content = messageContent,
                Email = email,
                Topic = topic,
                UserName = userName
                
            };

            var body = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(message));


            ch._channel.BasicPublish(ch._exchangeName,
                ch._routingKey,
                basicProperties: null,
                body: body);

            ch._channel.Close();
            ch._connection.Close();

        }
    }
}
