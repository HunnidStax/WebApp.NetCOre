using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Timesheets.Controllers.Models;
using Timesheets.Interfaces;
using Timesheets.Servises;

namespace Timesheets.Controllers
{
    public class PersonController : ControllerBase
    {
        private IPersonRepository _repo;
        private IMapper _mapper;

        public PersonController(IPersonRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        [HttpGet]
        //public async Task<IActionResult> GetPerson([FromQuery] PersonService userParams)
        //{
        //    var currentUserId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);

        //    var userFromRepo = await _repo.GetById(currentUserId);
        //    userParams.Id = currentUserId;

        //    var users = await _repo.GetById(userParams);

        //    var usersToRetrun = _mapper.Map<IEnumerable<PersonDto>>(users);

        //    //Response.AddPagination(users.CurrentPage, users.PageSize,
        //        //users.TotalCount, users.TotalPages);

        //    return Ok(usersToRetrun);
        //}

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetUser(int id)
        //{
        //    var user = await _repo.GetById(id);
        //    var userToRetrun = _mapper.Map<PersonDto>(user);

        //    return Ok(userToRetrun);
        //}

        //[HttpPut("{id}", Name = "GetUser")]
        //public async Task<IActionResult> UpdateUser(int id, PersonService userForUpdateDto)
        //{
        //    if (id != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
        //        return Unauthorized();

        //    var user = await _repo.GetById(id);
        //    _mapper.Map(userForUpdateDto, user);

        //    if (await _repo.SaveAll())
        //        return NoContent();

        //    throw new Exception("");
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteUser(int id)
        //{
        //    var user = _repo.GetById(id);

        //    _repo.Delete(user);

        //    if (await _repo.SaveAll())
        //    {
        //        return CreatedAtAction("GetUsers", new { });
        //    }

        //    throw new Exception("");
        //}
        
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
