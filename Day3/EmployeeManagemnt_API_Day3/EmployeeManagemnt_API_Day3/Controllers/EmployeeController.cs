using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagemnt_API_Day3.Models;

namespace EmployeeManagemnt_API_Day3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        Employee eObj = new Employee(); // this is bad code, we should use DI instead

        public IActionResult GetEployee
    }
}
