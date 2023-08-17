using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using System.Net;
using Yempo_API.Models;
using Yempo_API.Models.Dto;
using Yempo_API.Repository.IRepository;

namespace Yempo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        protected APIResponse _response;
        private readonly IPersonRepository _dbPerson;
        private readonly IMapper _mapper;

        public PersonController(IPersonRepository dbPerson, IMapper mapper)
        {
            _dbPerson = dbPerson;
            _mapper = mapper;
            this._response = new();
        }
        
        [HttpGet("HelloWorld")]
        public ContentResult About()
        {
            return Content("Hello World! - API Version: " + ApiVersion.Default);
        }

        [HttpGet(Name = "GetPersons")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetPersons()
        {
            try
            {

                IEnumerable<Person> personList = await _dbPerson.GetAllAsync();
                _response.Result = _mapper.Map<List<PersonDTO>>(personList);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;

        }

        [HttpGet("{id:int}", Name = "GetPerson")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetPerson(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var person = await _dbPerson.GetAsync(u => u.Id == id);
                if (person == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                _response.Result = _mapper.Map<PersonDTO>(person);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return _response;
        }
    }
}
