namespace RegistroEstudiantes.Dominio.Contratos
{
    using RegistroEstudiantes.Dominio.Entidades.Repositorio;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    public interface IEstudianteRepositorio
    {
        Task AgregarEstudiante(Estudiante estudiante);
        Task<List<Estudiante>> ConsultarEstudianteFiltro(Expression<Func<Estudiante, bool>> filtro);
        Task<List<Estudiante>> ConsultarEstudiantePorId(Guid id);
        Task EditarEstudiante(Estudiante estudiante);
        Task EliminarEstudiante(Guid id);


    }
}
