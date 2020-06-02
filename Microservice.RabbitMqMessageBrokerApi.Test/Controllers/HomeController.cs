using Microservice.RabbitMQMessageBrokerExtension;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.RabbitMqMessageBrokerApi.Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController:ControllerBase
    {
        private readonly IRabbitMessageBrokerClient _rabbitMessageBrokerClient;

        public HomeController(IRabbitMessageBrokerClient rabbitMessageBrokerClient)
        {
            _rabbitMessageBrokerClient = rabbitMessageBrokerClient;
        }

        [HttpGet("/publish")]
        public IActionResult Publish()
        {
            var foo = _rabbitMessageBrokerClient.Publish("test", "foobar");

            return Ok();
        }
    }
}
