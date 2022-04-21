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

        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetEmployee(int id) { return Ok(); }

        [HttpGet("get/{role}")]
        public async Task<IActionResult> GetEmployeeByRole(string role) { return Ok(); }

        [HttpPost("add")]
        public async Task<IActionResult> AddEmployee(int id) { return Ok(); }

        [HttpPut("{id}", Name = "GetEmployee")]
        public async Task<IActionResult> UpdateEmployee(int id, EmployeeDto employeeForUpdate) { return Ok(); }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id) { return Ok(); }
    }
}
