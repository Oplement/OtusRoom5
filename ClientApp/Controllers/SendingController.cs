using Microsoft.AspNetCore.Mvc;

namespace ClientApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SendingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            ViewData["balance"] = 10;
            ViewData["forSend"] = 20;
            ViewData["username"] = "Andrey Glazev";
            ViewData["userphoto"] = "http://protalismany.ru/wp-content/uploads/2018/11/na-foto-s-ulibkoi.jpg";
            return View();
        }
    }
}
