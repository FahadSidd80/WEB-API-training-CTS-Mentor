using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using employeeManagement_api.Models;
namespace employeeManagement_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        Employee eObj = new Employee(); //this is a bad code, we should use DI instead
        [HttpGet]
        [Route("/elist")]
        public IActionResult GetAllEmployee()
        {
            return Ok(eObj.GetAllEmployees());
        }

        [HttpGet]
        [Route("/elist/id/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            try
            {
                var result = eObj.GetEmployeeById(id);
                return Ok(result);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
            }
        }

        [HttpGet]
        [Route("/elist/ispermenant/{state}")]
        public IActionResult GetEmployeeByWorkStatus(bool state)
        {
            return Ok(eObj.GetPermenantEmployee(state));
        }
        [HttpGet]
        [Route("/elist/total")]
        public IActionResult GetTotalEmployees()
        {
            return Ok(eObj.GetTotalEmployees());
        }



        [HttpPost]
        [Route("/elist/add")]
        public IActionResult AddNewEmployee([FromBody]Employee empobj)
        {
            var addresult  = eObj.AddEmployee(empobj);
            return Created("", addresult);
        }
        [HttpDelete]
        [Route("/elist/delete/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            try
            {
                var deleteResult = eObj.DeleteEmployee(id);
                return Accepted(deleteResult);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
            }
        }
        [HttpPut]
        [Route("/elist/edit/{id}")]
        public IActionResult UpdateEmployee(int id,[FromBody]Employee empObj)
        {
            try
            {
                var updateResult = eObj.UpdateEmployee(id,empObj);
                return Ok(updateResult);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
                
            }
        }
    }
}


