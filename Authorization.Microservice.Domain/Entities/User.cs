namespace Authorization.Microservice.Domain
{
    public class User : IEntity
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }        
        public string? ImagePath { get; set; }
        public string PasswordHash{ get; set; }
    }
}
