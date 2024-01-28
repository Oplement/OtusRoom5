using Microsoft.AspNetCore.Mvc;
using Shop.Microservice.Domain.Common.Interfaces;

namespace Shop.Microservice.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RabbitmqController : ControllerBase
    {
        private readonly IProducer _producer;
        public RabbitmqController(IProducer prodecer)
        {
            _producer = prodecer;
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(string message, string topic, string userName, string email)
        {
            _producer.Produce(message,topic,userName,email);
            return Ok();
        }
    }
}
