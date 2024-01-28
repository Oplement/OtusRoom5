using Notification.Microservice.Core.Settings;
using RabbitMQ.Client;

namespace Notification.Microservice.Core.Services
{
    public class Channel
    {
        public string _queueName;
        public IModel _channel;
        public IConnection _connection;

        public Channel()
        {
            _queueName = "queue.direct";

            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true).Build();

            _connection = GetRabbitConnection(configuration);
            _channel = _connection.CreateModel();
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
