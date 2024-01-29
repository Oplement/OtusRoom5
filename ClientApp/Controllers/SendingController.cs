using Authorization.Microservice.Domain;
using ClientApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace ClientApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SendingController : Controller
    {
        RequestService _requestService;
        public SendingController(RequestService requestService)
        {
            _requestService = requestService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("getusers", Name ="getusers")]
        public string GetUsers( string name)
        {
            var response = _requestService.SendPost(MicroserviceDictionary.GetMicroserviceAdress("Authorization"),
           "auth/getUsersByFilter", new { filter =name}, this.HttpContext);
            return response.result.ToString();
        }

        [HttpPost("send", Name = "send")]
        public IActionResult Send([FromForm] Guid toID, [FromForm] string amount, [FromForm] string? comment)
        {
            if (comment == null)
            {
                comment = "";
            }


            // create transaction
            var response = _requestService.SendPost(MicroserviceDictionary.GetMicroserviceAdress("Shop"),
          "api/transactions/post", new {comment = comment, receiverid = toID, amount = amount, userid = this.HttpContext.Items["userid"].ToString() }, this.HttpContext);
           
            return RedirectToAction("Index");
        }
    }
}
