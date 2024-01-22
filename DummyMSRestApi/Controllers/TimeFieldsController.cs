using AutoMapper;
using DummyMSRestApi.Core.Contracts;
using DummyMSRestApi.Data;
using DummyMSRestApi.Core.Exceptions;
using DummyMSRestApi.Core.Models.TimeData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;

namespace DummyMSRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TimeFieldsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITimeRepository _timeRepository;

        public TimeFieldsController(IMapper mapper, ITimeRepository timeRepository)
        {
            this._mapper = mapper;
            this._timeRepository = timeRepository;
        }
        //GET api/TimeFields
        [HttpGet]
        [EnableQuery]
        public async Task<ActionResult<IEnumerable<TimeFiledsDto>>> GetTimeFields()
        {
            var timeFields = await _timeRepository.GetAllAsync();
            var elements = _mapper.Map<List<TimeFiledsDto>>(timeFields);
            return elements;
        }
        //GET api/TimeFields/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TimeFieldDto>> GetTimeField(string id)
        {
            var lineData = await _timeRepository.GetDetails(id);

            if (lineData == null)
            {
                throw new NotFoundException(nameof(GetTimeField), id);
            }
            var record = _mapper.Map<TimeFieldDto>(lineData);
            return record;
        }

        // PUT: api/TimeFields/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTimeField(string id, UpdateTimeDto timeDto)
        {
            if (id != timeDto.id)
            {
                return BadRequest();
            }
            var lineData = await _timeRepository.GetAsync(id);
            if (lineData == null)
            {
                throw new NotFoundException(nameof(PutTimeField), id);
            }

            _mapper.Map(timeDto, lineData);

            try
            {
                await _timeRepository.UpdateTimeData(lineData);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await LineDataExists(id))
                {
                    throw new NotFoundException(nameof(PutTimeField), id);
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
        public async Task<ActionResult<TimeFieldDto>> PostUserType(CreateTimeDto createTimeData)
        {
            var lineData = _mapper.Map<LineData<TimeFields>>(createTimeData);
            await _timeRepository.AddTimeData(lineData);

            return CreatedAtAction("GetTimeField", new { id = lineData.id }, lineData);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteUserType(string id)
        {
            var userType = await _timeRepository.GetAsync(id);
            if (userType == null)
            {
                throw new NotFoundException(nameof(DeleteUserType), id);
            }

            await _timeRepository.DeleteAsync(id);
            return NoContent();
        }
        private async Task<bool> LineDataExists(string id)
        {
            return await _timeRepository.Exists(id);
        }
    }
}
