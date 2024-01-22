using AutoMapper;
using DummyMSRestApi.Core.Contracts;
using DummyMSRestApi.Data;
using DummyMSRestApi.Core.Exceptions;
using DummyMSRestApi.Core.Models.TypeData;
using DummyMSRestApi.Core.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;

namespace DummyMSRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeFieldsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITypeRepository _typeRepository;

        public TypeFieldsController(IMapper mapper, ITypeRepository typeRepository)
        {
            this._mapper = mapper;
            this._typeRepository = typeRepository;
        }
        //GET api/TypeFields
        [HttpGet]
        [EnableQuery]
        public async Task<ActionResult<IEnumerable<TypeFieldsDto>>> GetTypeFields()
        {
            var typeFields = await _typeRepository.GetAllAsync();
            var elements = _mapper.Map<List<TypeFieldsDto>>(typeFields);
            return elements;
        }
        //GET api/TypeFields/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TypeFieldDto>> GetTypeField(string id)
        {
            var lineData = await _typeRepository.GetDetails(id);

            if (lineData == null)
            {
                throw new NotFoundException(nameof(GetTypeField), id);
            }
            var record = _mapper.Map<TypeFieldDto>(lineData);
            return record;
        }

        // PUT: api/TypeFields/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutTypeField(string id, UpdateTypeDto typeDto)
        {
            if (id != typeDto.id)
            {
                return BadRequest();
            }
            var lineData = await _typeRepository.GetAsync(id);
            if (lineData == null)
            {
                throw new NotFoundException(nameof(PutTypeField), id);
            }

            _mapper.Map(typeDto, lineData);

            try
            {
                await _typeRepository.UpdateTypeData(lineData);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await LineDataExists(id))
                {
                    throw new NotFoundException(nameof(PutTypeField), id);
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
        [Authorize]
        public async Task<ActionResult<TypeFieldDto>> PostUserType(CreateTypeDto createTypeData)
        {
            var lineData = _mapper.Map<LineData<TypeFields>>(createTypeData);
            await _typeRepository.AddTypeData(lineData);

            return CreatedAtAction("GetTypeField", new { id = lineData.id }, lineData);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteUserType(string id)
        {
            var userType = await _typeRepository.GetAsync(id);
            if (userType == null)
            {
                throw new NotFoundException(nameof(DeleteUserType), id);
            }

            await _typeRepository.DeleteAsync(id);
            return NoContent();
        }
        private async Task<bool> LineDataExists(string id)
        {
            return await _typeRepository.Exists(id);
        }
    }
}
