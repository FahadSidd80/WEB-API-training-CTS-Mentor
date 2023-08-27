using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace first_webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {

        [Route("/greetings")]
        [HttpGet]
        public IActionResult Greet()
        {
            return Ok("Hello and Welcome to the world of WebAPI Development");
        }

        [Route("/greetings/{guestName}")]
        [HttpGet]
        public IActionResult Greet(string guestName)
        {
            string message = "Hello " + guestName + " nice to have to here";
            return Ok(message);
        }
        
    }
}
