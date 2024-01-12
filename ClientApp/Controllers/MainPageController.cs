using ClientApp.Models;
using ClientApp.Services;
using Microsoft.AspNetCore.Mvc;
using Npgsql.Internal.TypeHandlers.DateTimeHandlers;
using Shop.Microservice.Domain.Common;

namespace ClientApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainPageController : Controller
    {
        RequestService _requestService;
        public MainPageController(RequestService requestService)
        {
            _requestService = requestService;
        }

        [Route("{id}")]
        [HttpGet]
        public IActionResult GetOne(string id)
        {

            return View();
        }

     
        [HttpGet]
        public IActionResult Index()
        {
            string service = MicroserviceDictionary.GetMicroserviceAdress("Shop");
            ResponseModel response_get_all_products = _requestService.SendGet(service , "api/products", this.HttpContext);

            var products = new List<Product>();

            if (response_get_all_products.success)
            {
                products = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(response_get_all_products.result.ToString());
            }

            return View(products);
        }
    }
}