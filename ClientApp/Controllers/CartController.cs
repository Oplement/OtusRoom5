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
            List<Product> cartProducts = new List<Product>
    {
        new Product { Id = Guid.NewGuid(), Title = "Товар 1", Description = "Описание товара 1", Price = 100, Image = "image-url-1" },
        new Product { Id = Guid.NewGuid(), Title = "Товар 2", Description = "Описание товара 2", Price = 200, Image = "image-url-2" },
        new Product { Id = Guid.NewGuid(), Title = "Товар 3", Description = "Описание товара 3", Price = 300, Image = "image-url-3" },
        new Product { Id = Guid.NewGuid(), Title = "Товар 4", Description = "Описание товара 4", Price = 400, Image = "image-url-4" },
        new Product { Id = Guid.NewGuid(), Title = "Товар 5", Description = "Описание товара 5", Price = 500, Image = "image-url-5" }
    };

            return View(cartProducts);
        }
    }
}
