namespace ejemploAPIEstructura.Entities.Interfaces.Repository
{
    public interface IAlumnoRepository : IRepositoryBase<Alumno>
    {
        IQueryable<Alumno> GetAllByFilter();
    }
}
