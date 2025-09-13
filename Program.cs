
using ejemploAPIEstructura.Data;
using ejemploAPIEstructura.Data.Repositoy;
using ejemploAPIEstructura.Entities.Interfaces.Repository;
using ejemploAPIEstructura.Entities.Interfaces.Service;
using ejemploAPIEstructura.Services;
using Microsoft.EntityFrameworkCore;

namespace ejemploAPIEstructura
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<UniversidadDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"))
                
            );

            

            builder.Services.AddTransient<IAlumnoService, AlumnoService>();
            builder.Services.AddTransient<IAlumnoRepository, AlumnoRepository>();


            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddAutoMapper(System.AppDomain.CurrentDomain.GetAssemblies());

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
