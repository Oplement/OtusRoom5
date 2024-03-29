﻿using Authorization.Microservice.Domain;
using ClientApp.Models;
using ClientApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClientApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminkaUsersController : Controller
    {
        RequestService _requestService;
        public AdminkaUsersController(RequestService requestService) 
        {
            _requestService = requestService;
        }

        [HttpGet("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            string authServiceAddress = MicroserviceDictionary.GetMicroserviceAdress("Authorization");
            ResponseModel response = _requestService.SendGet(authServiceAddress, "auth/getallusers", this.HttpContext);

            var userNames = new Dictionary<Guid, string>();

            if (response.success)
            {
                var users = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(response.result.ToString());

                return View(users);
                //foreach (var user in users)
                //{
                //    userNames[user.Id] = user.Username;
                //}
            }

            return View(userNames);
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
