using Authorization.Microservice.Domain;
using ClientApp.Models;
using ClientApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClientApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminkaUsersController : Controller
    {
        RequestService _requestService;
        public AdminkaUsersController(RequestService requestService)
        {
            _requestService = requestService;
        }

        [HttpGet("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            string authServiceAddress = MicroserviceDictionary.GetMicroserviceAdress("Authorization");
            ResponseModel response = _requestService.SendGet(authServiceAddress, "auth/getallusers", this.HttpContext);
          
            var users = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(response.result.ToString());

            return View(users);

        }

    }
}
