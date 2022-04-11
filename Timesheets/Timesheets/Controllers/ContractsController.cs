using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;

namespace Timesheets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractsController : ControllerBase
    {
        [HttpGet("get")]
        public async Task<IActionResult> GetAllContracts()
        {
            return Ok();
        }
        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetContractById([FromRoute] int id)
        {
            return Ok();
        }
        [HttpPut("add")]
        public async Task<IActionResult> AddContract([FromBody] ContractDto contract)
        {
            return Ok();
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteContract(int id)
        {
            return Ok();
        }
    }
}
