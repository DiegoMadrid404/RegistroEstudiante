namespace RegistroEstudiantes.API.Extencion.InyeccionDependecinas
{
    using RegistroEstudiantes.Aplicacion.Servicios.Estudiante;
    using RegistroEstudiantes.Aplicacion.Servicios.MateriaEstudiante;

    public static class Aplicacion
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ConsultarEstudianteServicio, ConsultarEstudianteServicio>();
            services.AddScoped<EditarEstudianteServicio, EditarEstudianteServicio>();
            services.AddScoped<EliminarEstudianteServicio, EliminarEstudianteServicio>();
            services.AddScoped<GuardarEstudianteServicio, GuardarEstudianteServicio>();
            services.AddScoped<GuardarMateriaEstudianteServicio, GuardarMateriaEstudianteServicio>();
            services.AddScoped<ConsultarMateriaEstudianteServicio, ConsultarMateriaEstudianteServicio>();

            return services;

        }
    }
} 
 