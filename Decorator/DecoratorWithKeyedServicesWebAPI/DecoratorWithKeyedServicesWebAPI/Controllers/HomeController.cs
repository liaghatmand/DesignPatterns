using DecoratorWithKeyedServicesWebAPI.Decorators;
using DecoratorWithKeyedServicesWebAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DecoratorWithKeyedServicesWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        private readonly ISMSProvider _sMSProvider;
        public HomeController(SMSDecorator sMSDecorator)
        {
            _sMSProvider = sMSDecorator;
        }

        [HttpGet(Name = "send")]
        public IActionResult Send()
        {
            _sMSProvider.Send("Asa");
            return Ok();
        }
        
    }
}
