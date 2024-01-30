using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;
using Shop.Microservice.Infrastructure.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Microservice.Infrastructure.Services
{
    public class Channel
    {
        public string _exchangeType;
        public string _exchangeName;
        public string _queueName;
        public string _routingKey;
        public IModel _channel;
        public IConnection _connection;

        public Channel()
        {
            _exchangeType = "direct";
            _exchangeName = "exchange.direct";
            _routingKey = "email";
            _queueName = "queue.direct";

            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("rmqsettings.json", true, true).Build();

            _connection = GetRabbitConnection(configuration);
            _channel = _connection.CreateModel();

            _channel.ExchangeDeclare(_exchangeName, _exchangeType, false, false, null);

            _channel.BasicQos(0, 10, false);
            _channel.QueueDeclare(_queueName, false, false, false, null);
            _channel.QueueBind(_queueName, _exchangeName, _routingKey, null);
        }

        private static IConnection GetRabbitConnection(IConfiguration configuration)
        {
            var rmqSettings = configuration.Get<AppSettings>().RmqSettings;

            ConnectionFactory connectionFactory = new ConnectionFactory
            {
                HostName = rmqSettings.Host,
                VirtualHost = rmqSettings.VHost,
                UserName = rmqSettings.Login,
                Password = rmqSettings.Password,
            };

            return connectionFactory.CreateConnection();
        }
    }
}
