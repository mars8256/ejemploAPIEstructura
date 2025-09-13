using ejemploAPIEstructura.Entities.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace ejemploAPIEstructura.Data.Repositoy
{
    public class Repository<T> : IRepositoryBase<T> where T : class
    {
        protected readonly UniversidadDbContext _context;
        protected readonly DbSet<T> _entities;
        public Repository(UniversidadDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context), "El contexto no puede ser nulo.");

            _entities = _context.Set<T>();
        }

        public async Task AddASync(T entity)
        {
            await _entities.AddAsync(entity);

            await _context.SaveChangesAsync();
        }

        public void DeleteASync(T entity)
        {
            if (entity != null) 
            {
                if (_entities.Contains(entity))
                {
                    _entities.Remove(entity);
                }
            }   
        }

        public IQueryable<T> GetAllAsync()
        {
            return _entities.AsQueryable();
        }

        public async Task<T?> GetByIdAsync(object id)
        {
            return await _entities.FindAsync(id);
        }

        public void UpdateASync(T entity)
        {
            _entities.Update(entity);
        }
    }
}
