﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RegistroEstudiantes.Models
{
    public partial class RegistroEstudianteContext : DbContext
    {
        public RegistroEstudianteContext()
        {
        }

        public RegistroEstudianteContext(DbContextOptions<RegistroEstudianteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<MateriaEstudiante> MateriaEstudiante { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MateriaEstudiante>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}