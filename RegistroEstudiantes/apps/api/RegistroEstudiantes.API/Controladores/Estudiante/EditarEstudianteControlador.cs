namespace RegistroEstudiantes.API.Controladores.Estudiante
{
    using Microsoft.AspNetCore.Mvc;
    using RegistroEstudiantes.Aplicacion.Servicios.Estudiante;
    using RegistroEstudiantes.Dominio.Entidades.Repositorio;

    [Route("Estudiante")]

    public class EditarEstudianteControlador : Controller
    {
        private readonly EditarEstudianteServicio editarEstudianteServicio;
        public EditarEstudianteControlador(EditarEstudianteServicio editarEstudianteServicio)
        {
            this.editarEstudianteServicio = editarEstudianteServicio;
        }


        [HttpPut]

        public async Task<bool> EditarEstudiante(Estudiante estudiante)
        {

            return await editarEstudianteServicio.EditarEstudiante(estudiante);
        }
    }
}
