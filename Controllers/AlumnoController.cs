using AutoMapper;
using ejemploAPIEstructura.Entities;
using ejemploAPIEstructura.Entities.Dtos.Request;
using ejemploAPIEstructura.Entities.Interfaces.Service;
using ejemploAPIEstructura.Entities.Mapper;
using ejemploAPIEstructura.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ejemploAPIEstructura.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        private IAlumnoService _service;
        private readonly IMapper _mapper;

        public AlumnoController(IAlumnoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public IEnumerable<IActionResult> Get() 
        { 
            return new List<IActionResult>();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AlumnoRequestDto alumnoRequestDto) 
        {

            var alumno = _mapper.Map<Alumno>(alumnoRequestDto);

            var result = await _service.Insert(alumno);

            return Ok(result);

          
        }

        [HttpPut]
        public IActionResult Put() 
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete() 
        {
            return Ok(null);
        }
    }
}
