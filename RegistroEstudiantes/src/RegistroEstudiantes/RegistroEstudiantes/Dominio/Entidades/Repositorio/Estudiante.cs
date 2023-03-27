namespace RegistroEstudiantes.Dominio.Entidades.Repositorio
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class Estudiante
    {
        public Guid Id { get; set; }
        public int? Cedula { get; set; }
        public string? Nombre { get; set; }

        public string? Apellido { get; set; }

        public int? Telefono { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public bool? Estado { get; set; }
    }
}