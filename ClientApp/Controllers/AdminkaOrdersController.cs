using Authorization.Microservice.Domain;
using ClientApp.Models;
using ClientApp.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Shop.Microservice.Domain.Common;
using Shop.Microservice.Domain.Entities;
using System.Diagnostics;

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

        [HttpPost("updateStatus")]
        public async Task<IActionResult> UpdateOrderStatus([FromForm] Guid orderid, [FromForm] string status)
        {
            string service = MicroserviceDictionary.GetMicroserviceAdress("Shop");
            ResponseModel response = _requestService.SendPost(service, "api/orders/updatestatus", new { id = orderid, status = status }, this.HttpContext);

            return Redirect("AllOrdersWithDetails");
        }

        [HttpGet("AllOrdersWithDetails")]
        public async Task<IActionResult> AllOrdersWithDetails()
        {
       
            var orders = new List<Order>();
            var users = new List<User>();
            var events = new List<ManualResetEvent>();

            var resetEvent = new ManualResetEvent(false);
            ThreadPool.QueueUserWorkItem((state) => 
            {
                string shopServiceAddress = MicroserviceDictionary.GetMicroserviceAdress("Shop");
                ResponseModel response = _requestService.SendGet(shopServiceAddress, "api/orders", this.HttpContext);
                orders = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Order>>(response.result.ToString());

                resetEvent.Set();
            });
            events.Add(resetEvent);

            var resetEvent2 = new ManualResetEvent(false);
            ThreadPool.QueueUserWorkItem((state) => 
            {
                string authServiceAddress = MicroserviceDictionary.GetMicroserviceAdress("Authorization");
                ResponseModel usersResponse = _requestService.SendGet(authServiceAddress, "auth/getallusers", this.HttpContext);
                users = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(usersResponse.result.ToString());

                resetEvent2.Set();
            });
            events.Add(resetEvent2);

            WaitHandle.WaitAll(events.ToArray());

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
