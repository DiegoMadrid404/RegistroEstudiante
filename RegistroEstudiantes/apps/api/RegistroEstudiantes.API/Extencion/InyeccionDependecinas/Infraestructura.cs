namespace RegistroEstudiantes.API.Extencion.InyeccionDependecinas
{
    using Microsoft.EntityFrameworkCore;
    using RegistroEstudiantes.Dominio.Contratos;
    using RegistroEstudiantes.Inftaestructura.Persistencia.EntityFramework;
    using RegistroEstudiantes.Inftaestructura.Repositorio;

    public static class Infraestructura
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
           IConfiguration configuration)
        {
            services.AddScoped<IEstudianteRepositorio, SqlServerEstudianteRepositorio>();
            services.AddScoped<IMateriaEstudianteRepsitorio, SqlServerMateriaEstudianteRepositorio>();
            services.AddDbContext<ContextoRegistroEstudiante>(options =>
               options.UseSqlServer(configuration.GetConnectionString("RegistroEstudianteBD").ToString()));
            return services;
        }
    }
}
