using AutoMapper;
using ejemploAPIEstructura.Entities;
using ejemploAPIEstructura.Entities.Dtos.Request;
using ejemploAPIEstructura.Entities.Dtos.Response;

namespace ejemploAPIEstructura.Mapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Alumno, AlumnoRequestDto>().ReverseMap();
            CreateMap<Alumno, AlumnoResponseDto>().ReverseMap();


        }
    }
}
