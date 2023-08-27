using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using di_cors_api_demo.Models.EF;

namespace di_cors_api_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class employeeController : ControllerBase
    {
        private readonly EmpEfContext _context;

        public employeeController(EmpEfContext context)
        {
            _context = context;
        }

        // GET: api/employee
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmpDetail>>> GetEmpDetails()
        {
          if (_context.EmpDetails == null)
          {
              return NotFound();
          }
            return await _context.EmpDetails.ToListAsync();
        }

        // GET: api/employee/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmpDetail>> GetEmpDetail(int id)
        {
          if (_context.EmpDetails == null)
          {
              return NotFound();
          }
            var empDetail = await _context.EmpDetails.FindAsync(id);

            if (empDetail == null)
            {
                return NotFound();
            }

            return empDetail;
        }

        // PUT: api/employee/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpDetail(int id, EmpDetail empDetail)
        {
            if (id != empDetail.EmpNo)
            {
                return BadRequest();
            }

            _context.Entry(empDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/employee
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmpDetail>> PostEmpDetail(EmpDetail empDetail)
        {
          if (_context.EmpDetails == null)
          {
              return Problem("Entity set 'EmpEfContext.EmpDetails'  is null.");
          }
            _context.EmpDetails.Add(empDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmpDetail", new { id = empDetail.EmpNo }, empDetail);
        }

        // DELETE: api/employee/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpDetail(int id)
        {
            if (_context.EmpDetails == null)
            {
                return NotFound();
            }
            var empDetail = await _context.EmpDetails.FindAsync(id);
            if (empDetail == null)
            {
                return NotFound();
            }

            _context.EmpDetails.Remove(empDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmpDetailExists(int id)
        {
            return (_context.EmpDetails?.Any(e => e.EmpNo == id)).GetValueOrDefault();
        }
    }
}
