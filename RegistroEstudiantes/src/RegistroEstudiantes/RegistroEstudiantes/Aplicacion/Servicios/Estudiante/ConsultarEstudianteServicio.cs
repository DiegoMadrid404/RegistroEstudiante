namespace RegistroEstudiantes.Aplicacion.Servicios.Estudiante
{
    using RegistroEstudiantes.Dominio.Contratos;
    using RegistroEstudiantes.Dominio.Entidades.Repositorio;
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    public class ConsultarEstudianteServicio
    {
        private readonly IEstudianteRepositorio _repositorio;

        public ConsultarEstudianteServicio(IEstudianteRepositorio repositorio)
        {
            _repositorio = repositorio;

        }


        public async Task<List<Estudiante>> Consultar(Estudiante estudiante)
        {
            Expression<Func<Estudiante, bool>> filtro = FiltrarConsulta(estudiante);

            return await _repositorio.ConsultarEstudianteFiltro(filtro);

        }
        private Expression<Func<Estudiante, bool>> FiltrarConsulta(Estudiante estudiante) => x => x.Estado == true &&
                                                                                              (estudiante.Id != Guid.Empty ? x.Id == estudiante.Id : true) &&
                                                                                              (estudiante.Cedula != null ? x.Cedula == estudiante.Cedula : true) &&
                                                                                              (!string.IsNullOrEmpty(estudiante.Nombre) ? x.Nombre == estudiante.Nombre : true) &&
                                                                                              (!string.IsNullOrEmpty(estudiante.Apellido) ? x.Apellido == estudiante.Apellido : true) &&
                                                                                              (estudiante.Telefono != null ? x.Telefono == estudiante.Telefono : true) &&
                                                                                              (estudiante.FechaNacimiento != null ? x.FechaNacimiento == estudiante.FechaNacimiento : true);


    }
}


