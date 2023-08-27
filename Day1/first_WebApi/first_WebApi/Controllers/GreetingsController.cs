using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace first_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {
        [Route("/greetings")]
        [HttpGet]
        public IActionResult Greet()
        {
            return Ok("Hello and welcome to the world of API Development");
        }

        [Route("/greetings/{guestName}")]
        [HttpGet]
        public IActionResult Greet(string guestName)
        {
            string message = "Hello " + guestName + " Nice to have here.";
            return Ok(message);
        }
    }
}
