using ClientApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClientApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : Controller
    {
        RequestService _requestService;
        public AuthController(RequestService requestService)
        {
                _requestService = requestService;
        }
        public IActionResult Index([FromQuery] string? error)
        {
           
            if (Request.Cookies.ContainsKey(".AspNetCore.User.Id"))
            {
                return Redirect("/mainpage");
            }

            if (error != null)
            {
                ViewData["error"] = error;
            }


            return View();
        }

        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            if (HttpContext.Request.Cookies.ContainsKey(".AspNetCore.User.Id"))
            {
                HttpContext.Response.Cookies.Delete(".AspNetCore.User.Id");
            }
            return Redirect("/auth");
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login([FromForm] string email, [FromForm] string password)
        {
            if (email == null || password == null)
            {
                return RedirectToAction("login", new { error = "Необходимо заполнить оба поля" });
            }

            var response = _requestService.SendPost(MicroserviceDictionary.GetMicroserviceAdress("Authorization"),
                "auth/login",new { email=email, password=password});

            if (response == null || response.result == null)
            {
                return RedirectToAction("login", new { error = "Неудачная попытка входа" });
            }
            if (!response.success)
            {
                return RedirectToAction("login", new { error = response.result });
            }

            Dictionary<string, string> keys = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(response.result.ToString());
            var key = keys.First().Value.ToString();

            HttpContext.Response.Cookies.Append(".AspNetCore.User.Id", key,
            new CookieOptions
            {
                // TODO: сколько нужно?
                MaxAge = TimeSpan.FromMinutes(100),
            });

            HttpContext.Request.Headers.Add(".AspNetCore.User.Id", key);

            return Redirect("/mainpage");            
        }
    }
}
