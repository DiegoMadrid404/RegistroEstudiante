using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace RegistroEstudiantes.Inftaestructura.Persistencia.EntityFramework
{
    using Microsoft.EntityFrameworkCore;
    using RegistroEstudiantes.Dominio.Entidades;
    using RegistroEstudiantes.Dominio.Entidades.Repositorio;

    public partial class ContextoRegistroEstudiante : DbContext
    {
         
        public ContextoRegistroEstudiante()
        {
        }

        public ContextoRegistroEstudiante(DbContextOptions<ContextoRegistroEstudiante> options)
                    : base(options)
        {
        }
        public virtual DbSet<Materia> Materia { get; set; }
        public virtual DbSet<MateriaEstudiante> MateriaEstudiante { get; set; }
        public virtual DbSet<Profesor> Profesor { get; set; }
        public virtual DbSet<ProfesorMateria> ProfesorMateria { get; set; }

        public virtual DbSet<Estudiante> Estudiante { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });


            modelBuilder.Entity<Materia>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
 
            modelBuilder.Entity<MateriaEstudiante>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

         

        modelBuilder.Entity<Profesor>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProfesorMateria>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.IdMateriaNavigation)
                    .WithMany(p => p.ProfesorMateria)
                    .HasForeignKey(d => d.IdMateria)
                    .HasConstraintName("FK__ProfesorM__IdMat__33D4B598");

                entity.HasOne(d => d.IdProfesorNavigation)
                    .WithMany(p => p.ProfesorMateria)
                    .HasForeignKey(d => d.IdProfesor)
                    .HasConstraintName("FK__ProfesorM__IdPro__34C8D9D1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}