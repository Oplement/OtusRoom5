using Microsoft.AspNetCore.Mvc;
using Shop.Microservice.Core.Models;
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
        public async Task<IActionResult> SendMessage([FromBody] RmqRequestModel requestModel)
        {
            _producer.Produce(requestModel.Content,requestModel.Topic,requestModel.UserName,requestModel.Email);
            return Ok();
        }
    }
}
