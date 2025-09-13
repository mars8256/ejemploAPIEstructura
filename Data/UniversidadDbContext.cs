using ejemploAPIEstructura.Entities;
using Microsoft.EntityFrameworkCore;

namespace ejemploAPIEstructura.Data
{
    public class UniversidadDbContext : DbContext
    {
        public UniversidadDbContext(DbContextOptions<UniversidadDbContext> options) : base(options)
        {
            
        }

        DbSet<Alumno> alumnos { get; set; }


    }
}
