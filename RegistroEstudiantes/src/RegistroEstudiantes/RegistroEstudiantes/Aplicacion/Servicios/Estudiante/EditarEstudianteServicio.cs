namespace RegistroEstudiantes.Aplicacion.Servicios.Estudiante
{
    using RegistroEstudiantes.Dominio.Contratos;
    using RegistroEstudiantes.Dominio.Entidades.Repositorio;
    using System;
    using System.Threading.Tasks;
    public class EditarEstudianteServicio
    {
        private readonly IEstudianteRepositorio _repositorio;

        public EditarEstudianteServicio(IEstudianteRepositorio repositorio)
        {
            _repositorio = repositorio;

        }


        public async Task<bool> EditarEstudiante(Estudiante estudiante)
        {
         
            await _repositorio.EditarEstudiante(estudiante);
            return true;

        }


    }
}


