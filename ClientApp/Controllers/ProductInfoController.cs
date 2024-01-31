using ClientApp.Models;
using ClientApp.Services;
using Microsoft.AspNetCore.Mvc;
using Shop.Microservice.Domain.Common;
using Shop.Microservice.Domain.Entities;

namespace ClientApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductInfoController : Controller
    {
        private readonly RequestService _requestService;

        public ProductInfoController(RequestService requestService)
        {
            _requestService = requestService;
        }

        [HttpGet("Info/{id}")]
        public IActionResult Info(Guid id)
        {
            string service = MicroserviceDictionary.GetMicroserviceAdress("Shop");
            ResponseModel response_get_product = _requestService.SendGet(service, $"api/products/{id}", this.HttpContext);

            var product = new Product();

            if (response_get_product.success)
            {
                product = Newtonsoft.Json.JsonConvert.DeserializeObject<Product>(response_get_product.result.ToString());
            }

            return View(product);
        }
    }
}
