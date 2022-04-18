using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;

namespace Timesheets.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet("persons /{id})")]
        public async Task<ActionResult<PersonDto>> GetById([FromRoute] int id)
        {
            return Ok();
        }

        [HttpGet("persons/search")]
        public async Task<IEnumerable<PersonDto>> FindByName([FromQuery] string SearchName,
            [FromQuery] int skip = 1,
            [FromQuery] int take = 50)
        {
            return (IEnumerable<PersonDto>)Ok();
        }

        [HttpGet("persons/search/all")]
        public async Task<IEnumerable<PersonDto>> FindAll([FromQuery] int skip = 1, [FromQuery] int take = 50)
        {
            return (IEnumerable<PersonDto>)Ok();
        }

        [HttpPost("persons/add")]
        public async Task<ActionResult<PersonDto>> AddAsync([FromBody] PersonDto person)
        {
            return Ok();
        }

        [HttpPut("persons/update")]
        public async Task<IActionResult> UpdateAsync([FromBody] PersonDto person)
        {
            return Ok();
        }

        [HttpDelete("persons/delete")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            return Ok();
        }
    }
}
