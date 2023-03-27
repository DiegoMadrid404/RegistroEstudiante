using Microsoft.AspNetCore.Mvc;
using RegistroEstudiantes.API.Controladores.MateriaEstudiante;
using RegistroEstudiantes.Aplicacion.Servicios.MateriaEstudiante;
using RegistroEstudiantes.Dominio.Entidades.Consulta;

namespace RegistroEstudiantes.API.Controladores.MateriaEstudiante
{
    using Microsoft.AspNetCore.Mvc;
    using RegistroEstudiantes.Aplicacion.Servicios.MateriaEstudiante;
    using RegistroEstudiantes.Dominio.Entidades.Consulta;
    using RegistroEstudiantes.Dominio.Entidades.Repositorio;

    [Route("MateriaEstudiante")]

    public class ConsultarMateriaEstudianteControlador : Controller
    {

        private readonly ConsultarMateriaEstudianteServicio consultarMateriaEstudianteServicio;
        public ConsultarMateriaEstudianteControlador(ConsultarMateriaEstudianteServicio consultarMateriaEstudianteServicio)
        {
            this.consultarMateriaEstudianteServicio = consultarMateriaEstudianteServicio;
        }


        [HttpGet("{idEstudiante}")]
 
        public async Task<List<MateriaEstudianteProfesor>> consultarMateriasEstudiante(Guid idEstudiante)
        {

            return await consultarMateriaEstudianteServicio.Consultar(idEstudiante);
        }
    }
}