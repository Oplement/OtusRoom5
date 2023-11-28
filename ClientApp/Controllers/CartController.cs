using Microsoft.AspNetCore.Mvc;

namespace ClientApp.Controllers
{
    public class CartController : Controller
    {
        [HttpGet("Cart")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPut("Put")]
        public IActionResult Put()
        {

            return View();
        }
    }
}
