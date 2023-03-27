namespace RegistroEstudiantes.Aplicacion.Servicios.Estudiante
{
    using RegistroEstudiantes.Dominio.Contratos;
    using RegistroEstudiantes.Dominio.Entidades.Repositorio;
    using System;
    using System.Threading.Tasks;
    public class GuardarEstudianteServicio
    {
        private readonly IEstudianteRepositorio _repositorio;

        public GuardarEstudianteServicio(IEstudianteRepositorio repositorio)
        {
            _repositorio = repositorio;

        }


        public async Task<bool> Guardar(Estudiante estudiante)
        {
            estudiante.FechaCreacion = DateTime.Now;
            estudiante.Id = Guid.NewGuid();
            estudiante.Estado = true;
            await _repositorio.AgregarEstudiante(estudiante);
            return true;

        }


    }
}


