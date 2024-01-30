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
            // Получение всех заказов
            string shopServiceAddress = MicroserviceDictionary.GetMicroserviceAdress("Shop");

            // Отправка запроса к API для получения всех заказов
            ResponseModel response = _requestService.SendGet(shopServiceAddress, "api/orders", this.HttpContext);

            // Десериализация ответа в список заказов
            var orders = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Order>>(response.result.ToString());
            

            // Получение пользователей
            string authServiceAddress = MicroserviceDictionary.GetMicroserviceAdress("Authorization");
            ResponseModel usersResponse = _requestService.SendGet(authServiceAddress, "auth/getallusers", this.HttpContext);
            var users = new List<User>();
            if (usersResponse.success)
            {
                users = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(usersResponse.result.ToString());
            }

            // Создание списка DTO
            var dict = new Dictionary<string, List<Order>>();

            foreach (var order in orders)
            {
                var user = users.FirstOrDefault(u => u.Id == order.UserId);
                if (!dict.ContainsKey(user.Email))
                {
                    dict.Add(user.Email, new List<Order>());
                }

                dict[user.Email].Add(order);
            }

            return View(dict);
        }

    }

}
