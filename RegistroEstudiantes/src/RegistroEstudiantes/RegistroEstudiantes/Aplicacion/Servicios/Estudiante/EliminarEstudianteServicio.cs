namespace RegistroEstudiantes.Aplicacion.Servicios.Estudiante
{
    using RegistroEstudiantes.Dominio.Contratos;
    using RegistroEstudiantes.Dominio.Entidades;
    using System;
    using System.Threading.Tasks;
    public class EliminarEstudianteServicio
    {
        private readonly IEstudianteRepositorio _repositorio;

        public EliminarEstudianteServicio(IEstudianteRepositorio repositorio)
        {
            _repositorio = repositorio;

        }


        public async Task<bool> Eliminar(Guid id)
        {
            await _repositorio.EliminarEstudiante(id);
            return true;

        }


    }
}


