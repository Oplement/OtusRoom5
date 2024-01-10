using ClientApp.Models;
using ClientApp.Services;
using Microsoft.AspNetCore.Mvc;
using Shop.Microservice.Domain.Common;

namespace ClientApp.Controllers
{
    public class CartController : Controller
    {
        RequestService _requestService;
        public CartController(RequestService requestService)
        {
            _requestService = requestService;
        }
        [HttpGet("Cart")]
        public IActionResult Index()
        {
            string service = MicroserviceDictionary.GetMicroserviceAdress("Shop");

            ResponseModel response = _requestService.SendGet(service, $"/api/orders?user={HttpContext.Items["username"]}", this.HttpContext);

            var cartOrder = new List<Product>();

            if (response.success)
            {
                cartOrder = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(response.result.ToString());
            }

            return View(cartOrder);
        }
        [HttpPut("Put")]
        public IActionResult Put()
        {


            return View();
        }
    }
}
