namespace RegistroEstudiantes.Aplicacion.Servicios.MateriaEstudiante
{
    using RegistroEstudiantes.Dominio.Contratos;
    using RegistroEstudiantes.Dominio.Entidades.Consulta;
    using RegistroEstudiantes.Dominio.Entidades.Repositorio;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    public class GuardarMateriaEstudianteServicio
    {
        private readonly IMateriaEstudianteRepsitorio _repositorio;

        public GuardarMateriaEstudianteServicio(IMateriaEstudianteRepsitorio repositorio)
        {
            _repositorio = repositorio;

        }


        public async Task<string> Guardar(MateriaEstudiante materiaEstudiante)
        {

            List<MateriaEstudiante> materiaEstudianteLista = this.ConsultarMateriaPorEstudiante(materiaEstudiante.IdEstudiante).Result;

            if (materiaEstudianteLista.Count >= 3)
            {
                return ("El estudiante ya tiene 3 materias registradas.");
            }

            List<MateriaEstudiante> materiaEstudianteProfesorLista = this.ConsultarMateriaEstudianteProfesor(materiaEstudiante.IdEstudiante, materiaEstudiante.IdProfesorMateria).Result;

            if (materiaEstudianteProfesorLista.Count >= 1)
            {
                return ("Ya se cuenta con materias asignadas a este profesor.");
            }

            return await _repositorio.AgregarMateriaEstudiante(materiaEstudiante);

        }
 

        private async Task<List<MateriaEstudiante>> ConsultarMateriaPorEstudiante(Guid idEstudiante)
        {

            return await _repositorio.ConsultarMateriaEstudianteFiltro(x => x.IdEstudiante == idEstudiante);
        }

        private async Task<List<MateriaEstudiante>> ConsultarMateriaEstudianteProfesor(Guid idEstudiante, Guid idMateriaProfesor)
        {

            return await _repositorio.ConsultarEstudianteProfesorRepetido(idEstudiante, idMateriaProfesor);
        }

    }
}


