namespace RegistroEstudiantes.API.Controladores.MateriaEstudiante
{
    using Microsoft.AspNetCore.Mvc;
     using RegistroEstudiantes.Aplicacion.Servicios.MateriaEstudiante;
    using RegistroEstudiantes.Dominio.Entidades.Repositorio;

    [Route("MateriaEstudiante")]

    public class GuardarMateriaEstudianteControlador : Controller
    {
        private readonly GuardarMateriaEstudianteServicio guardarMateriaEstudianteServicio;
        public GuardarMateriaEstudianteControlador(GuardarMateriaEstudianteServicio guardarMateriaEstudianteServicio)
        {
            this.guardarMateriaEstudianteServicio = guardarMateriaEstudianteServicio;
        }


        [HttpPost]

        public async Task<string> GuardarMateriaEstudiante(MateriaEstudiante materiaEstudiante)
        {

            return await guardarMateriaEstudianteServicio.Guardar(materiaEstudiante);
        }
    }
}
