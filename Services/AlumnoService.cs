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

        public Task<Alumno> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Alumno> Insert(Alumno alumno)
        {
            
            //logica de negocio
            if (alumno == null)
                throw new ArgumentNullException("El objeto alumno es requerido");

            //if (alumno.Carnet == null)
            //    throw new ArgumentNullException("El carnet es requerido.");

            if (alumno.Name == null)
                throw new Exception("Name is required");

            if (alumno.SecondName == null)
                throw new Exception("Second name is required");

            var carnetAnio = DateTime.Now.Year;

            var cede = "001";

            var correlativo = 100;

            alumno.Carnet = $"{carnetAnio}-{cede}-{correlativo}";


            alumno.FechaCreacion = DateTime.Now;
            alumno.FechaModificacion = null;

            await _repository.AddASync(alumno);

            

            return alumno;
            


        }
    }
}
