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
            // реальный запмрос
            //string service = MicroserviceDictionary.GetMicroserviceAdress("Shop");
            //ResponseModel response_get_all_products = _requestService.SendGet(service +"/api/getallproducts",this.HttpContext);


            //if (response_get_all_products.success)
            //{
            //    products = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(response_get_all_products.result.ToString());
            //}


            // тестовые данные
            var products = new List<Product>() { 
            new Product() { Count = 2, Description = "–азмеры S,M,L", Id = new Guid(), Price = 5999, Title = "’уди", Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg"},
            new Product(){ Count=5, Title = "ѕоверЅанк", Price = 2399, Description = "10000мјч", Id = new Guid(), Image="https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg" },
            new Product() { Count = 2, Description = "–азмеры S,M,L", Id = new Guid(), Price = 5999, Title = "’уди", Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg"},
            new Product(){ Count=5, Title = "ѕоверЅанк", Price = 2399, Description = "10000мјч", Id = new Guid(), Image="https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg" },
            new Product() { Count = 2, Description = "–азмеры S,M,L", Id = new Guid(), Price = 5999, Title = "’уди", Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg"},
            new Product(){ Count=5, Title = "ѕоверЅанк", Price = 2399, Description = "10000мјч", Id = new Guid(), Image="https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg" },
            new Product() { Count = 2, Description = "–азмеры S,M,L", Id = new Guid(), Price = 5999, Title = "’уди", Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg"},
            new Product(){ Count=5, Title = "ѕоверЅанк", Price = 2399, Description = "10000мјч", Id = new Guid(), Image="https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg" },
            new Product() { Count = 2, Description = "–азмеры S,M,L", Id = new Guid(), Price = 5999, Title = "’уди", Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg"},
            new Product(){ Count=5, Title = "ѕоверЅанк", Price = 2399, Description = "10000мјч", Id = new Guid(), Image="https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg" },
            };
            
            
            return View(products);
        }
    }
}