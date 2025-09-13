using ejemploAPIEstructura.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ejemploAPIEstructura.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocenteController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<IActionResult> Get()
        {
            return new List<IActionResult>();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Docente docenteRequestDto)
        {
            return Ok();
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
