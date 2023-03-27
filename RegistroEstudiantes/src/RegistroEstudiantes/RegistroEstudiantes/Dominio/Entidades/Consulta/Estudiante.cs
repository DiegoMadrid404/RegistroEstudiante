namespace RegistroEstudiantes.Dominio.Entidades.Consulta
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class MateriaEstudianteProfesor
    {
        public Guid IdProfesor { get; set; }
        public string? NombreProfesor { get; set; }
        public Guid IdEstudiante { get; set; }
        public string? NombreEstudiante { get; set; }

        public Guid  idMateria { get; set; }
        public string? NombreMateria { get; set; }


    }
}