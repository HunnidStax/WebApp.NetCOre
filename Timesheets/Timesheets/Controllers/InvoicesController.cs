using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;

namespace Timesheets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        [HttpGet("get")]
        public async Task<IActionResult> GetAllInvoices()
        {
            return Ok();
        }
        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetInvoiceById([FromRoute] int id)
        {
            return Ok();
        }
        [HttpPost("add")]
        public async Task<IActionResult> AddInvoice([FromBody] InvoicesDto contract)
        {
            return Ok();
        }
        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteInvoice(int id)
        {
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateInvoice([FromBody] int id) { return Ok(); }
        //[HttpPost]
    }
}
