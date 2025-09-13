using ejemploAPIEstructura.Entities.Dtos.Request;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace ejemploAPIEstructura.Entities.Mapper
{
    public class AlumnoMapper
    {
        public AlumnoMapper() { }

        public Alumno toEntity( AlumnoRequestDto alumnoDto) 
        {
            Alumno alumno = new Alumno();
            alumno.Id = alumnoDto.Id;
            alumno.Name = alumnoDto.Name;
            alumno.SecondName = alumnoDto.SecondName;

            return alumno;
        }
    }
}
