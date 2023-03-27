namespace RegistroEstudiantes.Aplicacion.Servicios.MateriaEstudiante
{
    using RegistroEstudiantes.Dominio.Contratos;
    using RegistroEstudiantes.Dominio.Entidades.Consulta;
    using RegistroEstudiantes.Dominio.Entidades.Repositorio;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public class ConsultarMateriaEstudianteServicio
    {
        private readonly IMateriaEstudianteRepsitorio _repositorio;

        public ConsultarMateriaEstudianteServicio(IMateriaEstudianteRepsitorio repositorio)
        {
            _repositorio = repositorio;

        }


        public async Task<List<MateriaEstudianteProfesor>> Consultar(Guid idEstudiante)
        {

            return await _repositorio.ConsultarMateriaEstudianteProfesor(idEstudiante);

        }



    }
}


