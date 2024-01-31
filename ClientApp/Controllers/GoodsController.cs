using ClientApp.Models;
using ClientApp.Services;
using Microsoft.AspNetCore.Mvc;
using Shop.Microservice.Domain.Common;
using Shop.Microservice.Domain.Entities;

namespace ClientApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GoodsController : Controller
    {
        RequestService _requestService;
        public GoodsController(RequestService requestService)
        {
            _requestService = requestService;
        }

        [HttpGet("Get/{id}")]
        public IActionResult Get(Guid id)
        {
            string service = MicroserviceDictionary.GetMicroserviceAdress("Shop");
            ResponseModel response_get_all_products = _requestService.SendGet(service, $"api/products/{id}", this.HttpContext);

            var product = new Product();

            if (response_get_all_products.success)
            {
                product = Newtonsoft.Json.JsonConvert.DeserializeObject<Product>(response_get_all_products.result.ToString());
            }

            return View(product);
        }

        [HttpPost("update")]
        public IActionResult UpdateProduct([FromForm]string title, [FromForm] int count,[FromForm] string description, [FromForm] string image, [FromForm] int price,[FromForm] Guid id)
        {
            string service = MicroserviceDictionary.GetMicroserviceAdress("Shop");

            ResponseModel response_get_all_products = _requestService.SendPost(
                service,
                $"api/products/update", 
                new {title=title, description = description, count = count, image=image, id = id, price = price},
                this.HttpContext);


            return Redirect($"Get/{id}");
        }
    }
}
