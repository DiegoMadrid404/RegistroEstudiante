﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RegistroEstudiantes.Models
{
    public partial class MateriaEstudiante
    {
        public Guid Id { get; set; }
        public Guid IdProfesorMateria { get; set; }
        public Guid IdEstudiante { get; set; }
        public int? Creditos { get; set; }
    }
}