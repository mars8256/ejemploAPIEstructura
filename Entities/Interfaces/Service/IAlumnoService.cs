namespace ejemploAPIEstructura.Entities.Interfaces.Service
{
    public interface IAlumnoService
    {
        Task<Alumno> Insert(Alumno alumno);
        Task Delete(int id, Alumno alumno);
        Task<Alumno> GetById(int id);
        List<Alumno> GetAll();
    }
}
