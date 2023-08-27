using Microsoft.AspNetCore.Mvc;

namespace httpclient_apicalls.Controllers
{
    public class ExternalDataController : Controller
    {


        public IActionResult DisplayPost()
        {
            return View();
        }
    }
}
