using ejemploAPIEstructura.Entities;
using ejemploAPIEstructura.Entities.Interfaces.Repository;

namespace ejemploAPIEstructura.Data.Repositoy
{
    public class AlumnoRepository : Repository<Alumno>, IAlumnoRepository
    {
        private UniversidadDbContext _context;
        public AlumnoRepository(UniversidadDbContext context) : base(context) 
        {
            _context = context;
        }

        public IQueryable<Alumno> GetAllByFilter()
        {
            return _entities.AsQueryable();
        }
    }
}
