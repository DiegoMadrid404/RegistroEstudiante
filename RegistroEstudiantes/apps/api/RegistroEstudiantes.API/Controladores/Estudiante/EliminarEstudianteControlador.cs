namespace RegistroEstudiantes.API.Controladores.Estudiante
{
    using Microsoft.AspNetCore.Mvc;
    using RegistroEstudiantes.Aplicacion.Servicios.Estudiante;
    using RegistroEstudiantes.Dominio.Entidades;

    [Route("Estudiante")]

    public class EliminarEstudianteControlador : Controller
    {
        private readonly EliminarEstudianteServicio eliminarEstudianteServicio;
        public EliminarEstudianteControlador(EliminarEstudianteServicio eliminarEstudianteServicio)
        {
            this.eliminarEstudianteServicio = eliminarEstudianteServicio;
        }


        [HttpDelete]

        public async Task<bool> EliminarEstudiante(Guid id)
        {

            return await eliminarEstudianteServicio.Eliminar(id);
        }
    }
}
