using ClientApp.Models;
using ClientApp.Services;
using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["balance"] = 10;
            ViewData["forSend"] = 20;
            ViewData["username"] = "Andrey Glazev";

            var products = new List<Product>();

            // реальный запрос
            //string service = MicroserviceDictionary.GetMicroserviceAdress("Shop");
            //ResponseModel response_get_all_products = _requestService.SendGet(service +"/api/getallproducts",this.HttpContext);


            //if (response_get_all_products.success)
            //{
            //    products = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(response_get_all_products.result.ToString());
            //}


            // затычка
            products = new List<Product>() { 
            new Product() { Count = 1, Description = "hi", Id = new Guid(), Price = 233, Title = "COK", Image = "https://tourpedia.ru/wp-content/uploads/2019/04/Уака-Ларга.jpg"},
            new Product(){ Count=5, Title = "КОФТА", Price = 2300, Description = "dfff", Id = new Guid(), Image="https://img.theculturetrip.com/1024x/wp-content/uploads/2018/02/1115609435_3dd77d8474_b.jpg" } };
            
            
            return View(products);
        }
    }
}