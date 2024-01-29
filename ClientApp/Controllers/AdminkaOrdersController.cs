using Authorization.Microservice.Domain;
using ClientApp.Models;
using ClientApp.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Shop.Microservice.Domain.Common;
using Shop.Microservice.Domain.Entities;

namespace ClientApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminkaOrdersController : Controller
    {
        private readonly RequestService _requestService;

        public AdminkaOrdersController(RequestService requestService)
        {
            _requestService = requestService;
        }

        [HttpGet("AllOrdersWithDetails")]
        public async Task<IActionResult> AllOrdersWithDetails()
        {
            // Получение адреса сервиса
            string shopServiceAddress = MicroserviceDictionary.GetMicroserviceAdress("Shop");
            string authServiceAddress = MicroserviceDictionary.GetMicroserviceAdress("Authorization");

            // Получение всех заказов с продуктами
            var orderProductsResponse = await _requestService.SendGetAsync(shopServiceAddress, "api/orderproducts/all", this.HttpContext);
            var orderProducts = orderProductsResponse.success
                ? Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderProduct>>(orderProductsResponse.result.ToString())
                : new List<OrderProduct>();

            // Получение данных о пользователях
            var usersResponse = await _requestService.SendGetAsync(authServiceAddress, "api/users/all", this.HttpContext);
            var users = usersResponse.success
                ? Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(usersResponse.result.ToString())
                : new List<User>();
            var userDictionary = users.ToDictionary(u => u.Id, u => u.Username);

            // Преобразование в DTO
            var orderProductUserDtos = orderProducts.Select(op => new OrderProductUserDto
            {
                OrderId = op.Order.Id,
                ProductTitle = op.Product.Title,
                ProductImage = op.Product.Image,
                ProductPrice = op.Product.Price,
                UserName = userDictionary.ContainsKey(op.Order.UserId) ? userDictionary[op.Order.UserId] : "Неизвестный пользователь",
                Count = op.Count,
                OrderStatus = op.Order.OrderStatus.ToString(),
                CreateAt = op.Order.CreateAt
            }).ToList();

            // Отправляем данные в представление
            return View(orderProductUserDtos);
        }

    }

    public class OrderProductUserDto
    {
        public Order Order { get; set; }
        public Product Product { get; set; }
        public string UserName { get; set; }
        public int Count { get; set; }
        public string OrderStatus { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
