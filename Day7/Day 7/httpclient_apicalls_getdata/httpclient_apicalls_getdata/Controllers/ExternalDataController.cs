using Microsoft.AspNetCore.Mvc;
using httpclient_apicalls_getdata.Models;
namespace httpclient_apicalls_getdata.Controllers
{
    public class ExternalDataController : Controller
    {
        PostData data = new PostData();
        
        public IActionResult DisplayPost()
        {
            ViewBag.post = data.GetPostDetails();
            
            return View();
        }
    }
}
