using ejemploAPIEstructura.Data.Repositoy;
using ejemploAPIEstructura.Entities;
using ejemploAPIEstructura.Entities.Interfaces.Repository;
using ejemploAPIEstructura.Entities.Interfaces.Service;

namespace ejemploAPIEstructura.Services
{
    public class AlumnoService : IAlumnoService
    {
        private IAlumnoRepository _repository;

        public AlumnoService(IAlumnoRepository repository)
        {
            _repository = repository;
        }
        public Task Delete(int id, Alumno alumno)
        {
            throw new NotImplementedException();
        }

        public List<Alumno> GetAll()
        {
            var alumnos = _repository.GetAllByFilter().ToList();

            if (alumnos == null)
                throw new Exception("Datos no encontrados");

            return (List<Alumno>)alumnos;
        }

        public Task<Alumno> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Alumno> Insert(Alumno alumno)
        {
            
            //logica de negocio
            if (alumno == null)
                throw new ArgumentNullException("El objeto alumno es requerido");

        

            if (alumno.Name == null)
                throw new Exception("Name is required");

            if (alumno.SecondName == null)
                throw new Exception("Second name is required");

            var carnetAnio = DateTime.Now.Year;

            var cede = "001";

            var correlativo = 100;

            alumno.Carnet = $"{carnetAnio}-{cede}-{correlativo}";


            alumno.IdUsuarioCreacion = 1;

            alumno.FechaCreacion = DateTime.Now;
            

            await _repository.AddASync(alumno);

            

            return alumno;
            


        }
    }
}
