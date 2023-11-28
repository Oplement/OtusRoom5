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
            ViewData["userphoto"] = "http://protalismany.ru/wp-content/uploads/2018/11/na-foto-s-ulibkoi.jpg";

            var products = new List<Product>();

            // �������� ������
            //string service = MicroserviceDictionary.GetMicroserviceAdress("Shop");
            //ResponseModel response_get_all_products = _requestService.SendGet(service +"/api/getallproducts",this.HttpContext);


            //if (response_get_all_products.success)
            //{
            //    products = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(response_get_all_products.result.ToString());
            //}


            // �������� ������
            products = new List<Product>() { 
            new Product() { Count = 2, Description = "������� S,M,L", Id = new Guid(), Price = 5999, Title = "����", Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg"},
            new Product(){ Count=5, Title = "���������", Price = 2399, Description = "10000���", Id = new Guid(), Image="https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg" },
             new Product() { Count = 2, Description = "������� S,M,L", Id = new Guid(), Price = 5999, Title = "����", Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg"},
            new Product(){ Count=5, Title = "���������", Price = 2399, Description = "10000���", Id = new Guid(), Image="https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg" },
             new Product() { Count = 2, Description = "������� S,M,L", Id = new Guid(), Price = 5999, Title = "����", Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg"},
            new Product(){ Count=5, Title = "���������", Price = 2399, Description = "10000���", Id = new Guid(), Image="https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg" },
            new Product() { Count = 2, Description = "������� S,M,L", Id = new Guid(), Price = 5999, Title = "����", Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg"},
            new Product(){ Count=5, Title = "���������", Price = 2399, Description = "10000���", Id = new Guid(), Image="https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg" },
             new Product() { Count = 2, Description = "������� S,M,L", Id = new Guid(), Price = 5999, Title = "����", Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg"},
            new Product(){ Count=5, Title = "���������", Price = 2399, Description = "10000���", Id = new Guid(), Image="https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg" },
            };
            
            
            return View(products);
        }
    }
}