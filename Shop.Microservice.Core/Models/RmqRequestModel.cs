namespace Shop.Microservice.Core.Models
{
    public class RmqRequestModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Topic { get; set; }
        public string Content { get; set; }

        public RmqRequestModel(string userName, string email, string topic, string content)
        {
            UserName = userName;
            Email = email;
            Topic = topic;
            Content = content;
        }
    }
}
