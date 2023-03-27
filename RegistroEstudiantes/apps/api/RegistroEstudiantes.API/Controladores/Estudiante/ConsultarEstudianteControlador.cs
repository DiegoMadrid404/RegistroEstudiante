namespace RegistroEstudiantes.API.Controladores.Estudiante
{
    using Microsoft.AspNetCore.Mvc;
    using RegistroEstudiantes.Aplicacion.Servicios.Estudiante;
    using RegistroEstudiantes.Dominio.Entidades.Repositorio;

    [Route("Estudiante")]

    public class ConsultarEstudianteControlador : Controller
    {
        private readonly ConsultarEstudianteServicio consultarEstudianteServicio;
        public ConsultarEstudianteControlador(ConsultarEstudianteServicio consultarEstudianteServicio)
        {
            this.consultarEstudianteServicio = consultarEstudianteServicio;
        }


        [HttpGet]

        public async Task<List<Estudiante>> ConsultarEstudianteFiltro(Estudiante estudiante)
        {

            return await consultarEstudianteServicio.Consultar(estudiante);
        }
    }
}
