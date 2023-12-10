using Microsoft.AspNetCore.Mvc;
using Shop.Microservice.Domain.Common;

namespace ClientApp.Controllers
{
    public class CartController : Controller
    {
        [HttpGet("Cart")]
        public IActionResult Index()
        {
            // Тестовый список продуктов.
            var cartProducts = new List<Product>() {
            new Product() { Count = 2, Description = "Размеры S,M,L", Id = new Guid(), Price = 5999, Title = "Худи", Image = "https://printing-t-shirts.podaru.ru/assets/images/products/760/wu6200043tif1000x1000.jpg"},
            new Product(){ Count=5, Title = "ПоверБанк", Price = 2399, Description = "10000мАч", Id = new Guid(), Image="https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg" },
                        new Product(){ Count=5, Title = "ПоверБанк", Price = 2399, Description = "10000мАч", Id = new Guid(), Image="https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg" },
            new Product(){ Count=5, Title = "ПоверБанк", Price = 2399, Description = "10000мАч", Id = new Guid(), Image="https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg" },
            new Product(){ Count=5, Title = "ПоверБанк", Price = 2399, Description = "10000мАч", Id = new Guid(), Image="https://sc04.alicdn.com/kf/HTB1TxHrfgoQMeJjy1Xaq6ASsFXay.jpg" },

            };

            ViewData["balance"] = 10;
            ViewData["forSend"] = 20;
            ViewData["username"] = "Andrey Glazev";
            ViewData["userphoto"] = "http://protalismany.ru/wp-content/uploads/2018/11/na-foto-s-ulibkoi.jpg";

            return View(cartProducts);
        }
        [HttpPut("Put")]
        public IActionResult Put()
        {


            return View();
        }
    }
}
