namespace RegistroEstudiantes.Inftaestructura.Repositorio

{
    using Microsoft.EntityFrameworkCore;
    using RegistroEstudiantes.Dominio.Contratos;
    using RegistroEstudiantes.Dominio.Entidades;
    using RegistroEstudiantes.Dominio.Entidades.Consulta;
    using RegistroEstudiantes.Dominio.Entidades.Repositorio;
    using RegistroEstudiantes.Inftaestructura.Persistencia.EntityFramework;
    using System.Collections.Generic;

    using System.Linq.Expressions;
    using System.Net.Http.Headers;
    using System.Security.Cryptography.X509Certificates;

    public class SqlServerMateriaEstudianteRepositorio : IMateriaEstudianteRepsitorio
    {
        private readonly ContextoRegistroEstudiante _context;


        /// <summary>

        /// Definición del constructor de la clase

        /// </summary>

        public SqlServerMateriaEstudianteRepositorio(ContextoRegistroEstudiante context)

        {

            _context = context;

        }



        public async Task<string> AgregarMateriaEstudiante(MateriaEstudiante materiaEstudiante)
        {
            await _context.MateriaEstudiante.AddAsync(materiaEstudiante);

            await _context.SaveChangesAsync();

            return ("Materia asignada correctamente");

        }

        public async Task<List<MateriaEstudiante>> ConsultarMateriaEstudianteFiltro(Expression<Func<MateriaEstudiante, bool>> filtro)
        {
            List<MateriaEstudiante> listaMateriaEstudiante = _context.MateriaEstudiante.Where(filtro).ToList();

            return listaMateriaEstudiante;
        }




        public async Task<List<MateriaEstudianteProfesor>> ConsultarMateriaEstudianteProfesor(Guid idEstudianteFiltro)
        {
            return (from materiaEstudiante in _context.MateriaEstudiante.Where(x => x.IdEstudiante == idEstudianteFiltro)
                    join estudiante in _context.Estudiante on materiaEstudiante.IdEstudiante equals estudiante.Id
                    join materiaProfesor in _context.ProfesorMateria on materiaEstudiante.IdProfesorMateria equals materiaProfesor.Id
                    join profesor in _context.Profesor on materiaProfesor.IdProfesor equals profesor.Id
                    join materia in _context.Materia on materiaProfesor.IdMateria equals materia.Id
                    select new MateriaEstudianteProfesor
                    {
                        IdEstudiante = estudiante.Id,
                        NombreEstudiante = $"{estudiante.Nombre} {estudiante.Apellido}",
                        IdProfesor = profesor.Id,
                        NombreProfesor = $"{profesor.Nombre} {profesor.Apellido}",
                        idMateria = materia.Id,
                        NombreMateria = materia.Nombre

                    }).ToList<MateriaEstudianteProfesor>();

        }


        public async Task<List<MateriaEstudiante>> ConsultarEstudianteProfesorRepetido(Guid idEstudianteFiltro, Guid idMateriaProfesor)
        {


            return (from materiaEstudiante in _context.MateriaEstudiante.Where(x => x.IdEstudiante == idEstudianteFiltro)
                    join materiaProfesor in _context.ProfesorMateria.Where(x => x.Id == idMateriaProfesor) on materiaEstudiante.IdProfesorMateria equals materiaProfesor.Id
                    select materiaEstudiante).ToList<MateriaEstudiante>();

        }
    }

}