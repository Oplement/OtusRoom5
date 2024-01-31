using ClientApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClientApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreateUserController : Controller
    {
        RequestService _requestService;
        public CreateUserController(RequestService requestService)
        {
            _requestService = requestService;
        }



        [HttpPost("create", Name = "create")]
        public IActionResult Create([FromForm] string username, [FromForm] string email, [FromForm] string password, [FromForm] string role)
        {

            _requestService.SendPost(MicroserviceDictionary.GetMicroserviceAdress("Authorization"),
                "auth/register", new { username = username, email = email, password = password, role = role }, this.HttpContext);

            return Redirect("/AdminkaUsers/GetUsers");
            
        }
            
        
    }
    
}
