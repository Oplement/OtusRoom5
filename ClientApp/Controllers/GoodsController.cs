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

        [HttpGet("Patch")]
        public IActionResult Patch()
        {
            string service = MicroserviceDictionary.GetMicroserviceAdress("Shop");
            ResponseModel response_get_all_products = _requestService.SendGet(service, "api/products", this.HttpContext);

            var products = new List<Product>();

            if (response_get_all_products.success)
            {
                products = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(response_get_all_products.result.ToString());
            }

            return View(products);
        }

        //[HttpGet("AllOrdersWithUsers")]
        //public async Task<IActionResult> AllOrdersWithUsers()
        //{
        //    var orders = GetAllOrders();
        //    var userNames = await GetUserNames();

        //    var ordersWithUsers = orders.Select(order => new OrderWithUserDto
        //    {
        //        Order = order,
        //        UserName = userNames.ContainsKey(order.UserId) ? userNames[order.UserId] : "Неизвестный пользователь"
        //    }).ToList();

        //    return View(ordersWithUsers);
        //}

        //public List<Order> GetAllOrders()
        //{
        //    string shopServiceAddress = MicroserviceDictionary.GetMicroserviceAdress("Shop");
        //    ResponseModel response = _requestService.SendGet(shopServiceAddress, "api/orders/all", this.HttpContext);

        //    if (response.success)
        //    {
        //        return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Order>>(response.result.ToString());
        //    }

        //    return new List<Order>();
        //}

    }
    //public class OrderWithUserDto
    //{
    //    public Order Order { get; set; }
    //    public string UserName { get; set; }
    //}
}
