using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SMI.Infrastructure.Data
{
    public partial class SMIContext : DbContext
    {
        public SMIContext()
        {
        }

        public SMIContext(DbContextOptions<SMIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actividad> Actividad { get; set; }
        public virtual DbSet<Edificio> Edificio { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Espacio> Espacio { get; set; }
        public virtual DbSet<Mantenimiento> Mantenimiento { get; set; }
        public virtual DbSet<MantenimientoProgramado> MantenimientoProgramado { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actividad>(entity =>
            {
                entity.Property(e => e.Actividad1)
                    .IsRequired()
                    .HasColumnName("Actividad")
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMantenimientoNavigation)
                    .WithMany(p => p.Actividad)
                    .HasForeignKey(d => d.IdMantenimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PerteneceA");
            });

            modelBuilder.Entity<Edificio>(entity =>
            {
                entity.Property(e => e.Ancho)
                    .HasColumnType("decimal(4, 2)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.FechaEdificacion).HasColumnType("date");

                entity.Property(e => e.Largo)
                    .HasColumnType("decimal(4, 2)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Sin Email')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('Sin Numero')");
            });

            modelBuilder.Entity<Espacio>(entity =>
            {
                entity.Property(e => e.Ancho)
                    .HasColumnType("decimal(4, 2)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Largo)
                    .HasColumnType("decimal(4, 2)")
                    .HasDefaultValueSql("((0.0))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEdificioNavigation)
                    .WithMany(p => p.Espacio)
                    .HasForeignKey(d => d.IdEdificio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SeEncuentraEn");
            });

            modelBuilder.Entity<Mantenimiento>(entity =>
            {
                entity.Property(e => e.Mantenimiento1)
                    .IsRequired()
                    .HasColumnName("Mantenimiento")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MantenimientoProgramado>(entity =>
            {
                entity.Property(e => e.FechaEstablecidad).HasColumnType("date");

                entity.Property(e => e.FechaFinProgramada).HasColumnType("date");

                entity.Property(e => e.FechaFinRealizacion).HasColumnType("date");

                entity.Property(e => e.Observaciones)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Sin observaciones')");

                entity.HasOne(d => d.IdActividadNavigation)
                    .WithMany(p => p.MantenimientoProgramado)
                    .HasForeignKey(d => d.IdActividad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SeVaARelizar");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.MantenimientoProgramado)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("EsAsiganadaA");

                entity.HasOne(d => d.IdEspacioNavigation)
                    .WithMany(p => p.MantenimientoProgramado)
                    .HasForeignKey(d => d.IdEspacio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SeReaalizaEn");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
