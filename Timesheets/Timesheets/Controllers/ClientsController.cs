using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;

namespace Timesheets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        [HttpGet("get")]
        public async Task<IActionResult> GetAllClients()
        {
            return Ok();
        }
        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetClient(int id)
        {
            return Ok();
        }

        [HttpPut("{id}", Name = "GetUser")]
        public async Task<IActionResult> UpdateClient(int id, ClientDto userForUpdate)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            return Ok();
        }
    }
}
