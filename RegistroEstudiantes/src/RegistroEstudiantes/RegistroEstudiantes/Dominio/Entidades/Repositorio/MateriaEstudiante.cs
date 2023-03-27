namespace RegistroEstudiantes.Dominio.Entidades.Repositorio
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Representa la relación entre un estudiante y una materia, junto con el profesor encargado de dicha materia.
    /// </summary>
    public partial class MateriaEstudiante
    {
    
        public Guid? Id { get; set; }
        public Guid IdProfesorMateria { get; set; }
         

        public Guid IdEstudiante { get; set; }
         

        public int? Creditos { get; set; } 
    }
}
