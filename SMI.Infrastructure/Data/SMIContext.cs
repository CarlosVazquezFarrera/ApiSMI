using Microsoft.EntityFrameworkCore;
using SMI.Core.Entites;
using SMI.Infrastructure.Data.Configurations;

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
            modelBuilder.ApplyConfiguration(new ActividadConfiguration());
            modelBuilder.ApplyConfiguration(new EdificioConfiguration());
            modelBuilder.ApplyConfiguration(new EmpleadoConfiguration());
            modelBuilder.ApplyConfiguration(new MantenimientoConfiguration());
            modelBuilder.ApplyConfiguration(new EspacioConfiguration());
            modelBuilder.ApplyConfiguration(new MantenimientoProgramadoConfiguration());

        }

    }
}
