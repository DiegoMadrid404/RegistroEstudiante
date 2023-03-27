namespace RegistroEstudiantes.Inftaestructura.Repositorio

{
    using Microsoft.EntityFrameworkCore;
    using RegistroEstudiantes.Dominio.Contratos;
    using RegistroEstudiantes.Dominio.Entidades.Repositorio;
    using RegistroEstudiantes.Inftaestructura.Persistencia.EntityFramework;
    using System.Collections.Generic;

    using System.Linq.Expressions;



    public class SqlServerEstudianteRepositorio : IEstudianteRepositorio
    {
        private readonly ContextoRegistroEstudiante _context;


        /// <summary>

        /// Definición del constructor de la clase

        /// </summary>

        public SqlServerEstudianteRepositorio(ContextoRegistroEstudiante context)

        {

            _context = context;

        }



        /// <summary>

        ///

        /// </summary>

        /// <param name="paquete"></param>

        /// <returns></returns>

        public async Task AgregarEstudiante(Estudiante estudiante)

        {

            await _context.Estudiante.AddAsync(estudiante);

            await _context.SaveChangesAsync();

        }



        public async Task<List<Estudiante>> ConsultarEstudianteFiltro(Expression<Func<Estudiante, bool>> filtro)
        {

            List<Estudiante> listaEstudiante = _context.Estudiante.Where(filtro).ToList();

            return listaEstudiante;

        }



        public async Task<List<Estudiante>> ConsultarEstudiantePorId(Guid id)

        {

            List<Estudiante> listaEstudiante = _context.Estudiante.Where(x => x.Id == id).ToList();

            return listaEstudiante;

        }



        public async Task EditarEstudiante(Estudiante estudiante)

        {


            _context.Update(estudiante);

            await _context.SaveChangesAsync();

        }

        public async Task EliminarEstudiante(Guid id)
        {
            Estudiante estudianteEliminar = _context.Estudiante.Where(x => x.Id == id).FirstOrDefault();

            _context.Estudiante.Remove(estudianteEliminar);

            await _context.SaveChangesAsync();

        }



    }

}