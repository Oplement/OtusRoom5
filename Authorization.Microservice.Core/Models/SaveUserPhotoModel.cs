namespace Authorization.Microservice.Core.Models
{
    public class SaveUserPhotoModel
    {
        public string ImagePath{ get; set; }
        public Guid UserId { get; set; }
        public SaveUserPhotoModel(string imagePath, Guid userid)
        {
            ImagePath = imagePath;
            UserId = userid;
        }
    }
}
