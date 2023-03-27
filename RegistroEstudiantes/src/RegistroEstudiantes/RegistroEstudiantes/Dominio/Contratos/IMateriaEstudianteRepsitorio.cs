namespace RegistroEstudiantes.Dominio.Contratos
{
    using RegistroEstudiantes.Dominio.Entidades;
    using RegistroEstudiantes.Dominio.Entidades.Consulta;
    using RegistroEstudiantes.Dominio.Entidades.Repositorio;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    public interface IMateriaEstudianteRepsitorio
    {
        Task<string> AgregarMateriaEstudiante(MateriaEstudiante estudiante);
        Task<List<MateriaEstudiante>> ConsultarMateriaEstudianteFiltro(Expression<Func<MateriaEstudiante, bool>> filtro);
        Task<List<MateriaEstudianteProfesor>> ConsultarMateriaEstudianteProfesor(Guid idEstudiante);

        Task<List<MateriaEstudiante>> ConsultarEstudianteProfesorRepetido(Guid idEstudianteFiltro, Guid idMateriaProfesor);



    }
}
