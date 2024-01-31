using ClientApp.Models;
using ClientApp.Services;
using Microsoft.AspNetCore.Mvc;
using Shop.Microservice.Domain.Common;
using Shop.Microservice.Domain.Entities;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

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

        [HttpGet("Get/{id}")]
        public IActionResult Get(Guid id)
        {
            string service = MicroserviceDictionary.GetMicroserviceAdress("Shop");
            ResponseModel response_get_all_products = _requestService.SendGet(service, $"api/products/{id}", this.HttpContext);

            var product = new Product();

            if (response_get_all_products.success)
            {
                product = Newtonsoft.Json.JsonConvert.DeserializeObject<Product>(response_get_all_products.result.ToString());
            }

            return View(product);
        }

        [HttpPost("update")]
        public IActionResult UpdateProduct([FromForm]string title, [FromForm] int count,[FromForm] string description, [FromForm] string image, [FromForm] int price,[FromForm] Guid id)
        {
            string service = MicroserviceDictionary.GetMicroserviceAdress("Shop");

            _requestService.SendPost(
                service,
                $"api/products/update", 
                new {title=title, description = description, count = count, image=image, id = id, price = price},
                this.HttpContext);


            return Redirect($"Get/{id}");
        }

        [RequestFormLimits(ValueLengthLimit = int.MaxValue, MultipartBodyLengthLimit = int.MaxValue)]
        [HttpPost("updatePhoto")]
        public IActionResult UpdatePhoto([FromForm] Guid prodid)
        {
            var file = Request.Form.Files[0];
            string imageName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/content/products", imageName);

            var events = new List<ManualResetEvent>();

            var resetEvent = new ManualResetEvent(false);
            ThreadPool.QueueUserWorkItem(async (state) => { await UpdatePhoto(prodid, imageName);  resetEvent.Set(); });
            events.Add(resetEvent);

            var resetEvent2 = new ManualResetEvent(false);

            ThreadPool.QueueUserWorkItem(async (state) => { await SaveFile(savePath, file); resetEvent2.Set();  });
            events.Add(resetEvent2);

            WaitHandle.WaitAll(events.ToArray());

            return Redirect("/mainpage");
        }
        private async Task UpdatePhoto(Guid prodid, string imageName)
        {
            string service = MicroserviceDictionary.GetMicroserviceAdress("Shop");

            _requestService.SendPost(
                service,
                $"api/products/updatePhoto",
                new { id = prodid, path = "/content/products/" + imageName },
                this.HttpContext);
        }
        private async Task SaveFile(string savePath, IFormFile file)
        {
            using (var stream = new FileStream(savePath, FileMode.Create))
            {
                file.CopyTo(stream);
            }
        }
    }
}
