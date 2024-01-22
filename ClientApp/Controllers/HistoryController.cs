using ClientApp.Models;
using ClientApp.Services;
using Microsoft.AspNetCore.Mvc;
using Shop.Microservice.Domain.Entities;

namespace ClientApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HistoryController : Controller
    {
        RequestService _requestService;
        public HistoryController(RequestService requestService) 
        {
            _requestService = requestService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            string service = MicroserviceDictionary.GetMicroserviceAdress("Shop");
            
            ResponseModel model = _requestService.SendGet(service,$"api/orders/user_id?userid={HttpContext.Items["userid"]}",this.HttpContext);

            var historyOrders = new List<OrderProduct>();

            if (model.success)
            {
                historyOrders = Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderProduct>>(model.result.ToString());
            }

            return View(historyOrders);
        }
    }
}
