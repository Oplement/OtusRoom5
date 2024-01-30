using Authorization.Microservice.Domain;
using ClientApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClientApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : Controller
    {
        private readonly RequestService _requestService;
        public ProfileController(RequestService requestService)
        {
            _requestService = requestService;
        }
        public IActionResult Index()
        {
            var user = new User()
            {
                Email = this.HttpContext.Items["email"].ToString(),
                Id = Guid.Parse(this.HttpContext.Items["userid"].ToString()),
                ImagePath = this.HttpContext.Items["userphoto"].ToString(),
                Role = this.HttpContext.Items["role"].ToString(),
                Username = this.HttpContext.Items["username"].ToString(),

            };

            return View(user);
        }
        [RequestFormLimits(ValueLengthLimit = int.MaxValue, MultipartBodyLengthLimit = int.MaxValue)]

        [HttpPost("savephoto", Name ="savephoto")]
        public IActionResult SavePhoto()
        {
            var file = Request.Form.Files[0];
            string imageName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/content/avatars", imageName);
            using (var stream = new FileStream(savePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            var response = _requestService.SendPost(MicroserviceDictionary.GetMicroserviceAdress("Authorization"),
              "user/savephoto", new { userid = this.HttpContext.Items["userid"], imagePath = "/content/avatars" + imageName }, this.HttpContext);

            return RedirectToAction("Index");
        }

        [HttpPost("saveuser", Name = "saveuser")]
        public IActionResult SaveUser([FromForm] string email, [FromForm] string newpass, [FromForm] string username)
        {
     
             _requestService.SendPost(MicroserviceDictionary.GetMicroserviceAdress("Authorization"),
                        "user/saveinfo", new { userid = this.HttpContext.Items["userid"], username = username, email = email, newpass = newpass}, this.HttpContext);
     

            return Redirect("/auth/logout");
        }


    }
}
