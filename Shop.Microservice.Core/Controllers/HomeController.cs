using Microsoft.AspNetCore.Mvc;

namespace Shop.Microservice.Core.Controllers;

[ApiController]
[Route("/home")]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        var f = User;
        return View();
    }
}