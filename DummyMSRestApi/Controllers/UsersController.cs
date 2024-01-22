using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DummyMSRestApi.Data;
using DummyMSRestApi.Core.Models.User;
using AutoMapper;
using DummyMSRestApi.Core.Contracts;
using Microsoft.AspNetCore.Authorization;
using DummyMSRestApi.Core.Exceptions;
using Microsoft.AspNetCore.OData.Query;

namespace DummyMSRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public UsersController(IMapper mapper, IUserRepository userRepository)
        {
            this._mapper = mapper;
            this._userRepository = userRepository;
        }

        // GET: api/Users
        [HttpGet]
        [EnableQuery]
        public async Task<ActionResult<IEnumerable<UsersDto>>> GetUserType()
        {
            var users = await _userRepository.GetAllAsync();
            var elememnts = _mapper.Map<List<UsersDto>>(users); 
            return Ok(elememnts);
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetUserType(string id)
        {
            var userType = await _userRepository.GetAsync(id);

            if (userType == null)
            {
                throw new NotFoundException(nameof(GetUserType), id);
            }
            var record = _mapper.Map<UserDto>(userType); 
            return record;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserType(string id, UpdateUserDto userType)
        {
            if (id != userType.Id)
            {
                return BadRequest();
            }
            var user = await _userRepository.GetAsync(id); 
            if (user == null)
            {
                throw new NotFoundException(nameof(PutUserType), id);
            }

            _mapper.Map(userType, user);

            try
            {
                await _userRepository.UpdateAsync(user);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await UserTypeExists(id))
                {
                    throw new NotFoundException(nameof(PutUserType), id);
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UserType>> PostUserType(CreateUserDto createUser)
        {
            var user = _mapper.Map<UserType>(createUser);
            await _userRepository.AddAsync(user);
          
            return CreatedAtAction("GetUserType", new { id = user.Id }, user);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteUserType(string id)
        {
            var userType = await _userRepository.GetAsync(id);
            if (userType == null)
            {
                throw new NotFoundException(nameof(DeleteUserType), id);
            }

            await _userRepository.DeleteAsync(id);
            return NoContent();
        }
        private async Task<bool> UserTypeExists(string id)
        {
            return await _userRepository.Exists(id);
        }
    }
}
