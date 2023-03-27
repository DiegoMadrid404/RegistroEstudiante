namespace RegistroEstudiantes.API.Controladores.Estudiante
{
    using Microsoft.AspNetCore.Mvc;
    using RegistroEstudiantes.Aplicacion.Servicios.Estudiante;
    using RegistroEstudiantes.Dominio.Entidades.Repositorio;

    [Route("Estudiante")]

    public class GuardarEstudianteControlador : Controller
    {
        private readonly GuardarEstudianteServicio guardarEstudianteServicio;
        public GuardarEstudianteControlador(GuardarEstudianteServicio guardarEstudianteServicio)
        {
            this.guardarEstudianteServicio = guardarEstudianteServicio;
        }


        [HttpPost]

        public async Task<bool> GuardarEstudiante(Estudiante estudiante)
        {

            return await guardarEstudianteServicio.Guardar(estudiante);
        }
    }
}
