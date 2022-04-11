using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;

namespace Timesheets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet("get")]
        public async Task<IActionResult> GetAllEmmloyees()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            return Ok();
        }

        [HttpPut("{id}", Name = "GetEmploye")]
        public async Task<IActionResult> UpdateEmployee(int id, EmployeeDto employeeForUpdate)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            return Ok();
        }
    }
}
