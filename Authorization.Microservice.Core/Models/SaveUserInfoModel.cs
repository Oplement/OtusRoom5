namespace Authorization.Microservice.Core.Models
{
    public class SaveUserInfoModel
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string NewPass { get; set; }
        public string Email { get; set; }
        public SaveUserInfoModel(Guid userid, string username, string newpass, string email )
        {
            UserId = userid;
            Username = username;
            NewPass = newpass;
            Email = email;
        }
    }
}
