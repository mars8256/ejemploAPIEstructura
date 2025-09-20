using AutoMapper;
using ejemploAPIEstructura.Entities;
using ejemploAPIEstructura.Entities.Dtos.Request;
using ejemploAPIEstructura.Entities.Dtos.Response;
using ejemploAPIEstructura.Entities.Interfaces.Service;
using ejemploAPIEstructura.Entities.Mapper;
using ejemploAPIEstructura.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ejemploAPIEstructura.Controllers
{
    //[Authorize]
    [Produces("application/json")]
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
        public IActionResult Get()
        {
            var result = _service.GetAll();
            var resultDto = _mapper.Map<IEnumerable<AlumnoResponseDto>>(result);
            return Ok(resultDto);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AlumnoRequestDto alumnoRequestDto) 
        {

            var alumno = _mapper.Map<Alumno>(alumnoRequestDto);

            var result = await _service.Insert(alumno);

            var respponse = _mapper.Map<AlumnoResponseDto>(result);

            return Ok(respponse);

          
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
