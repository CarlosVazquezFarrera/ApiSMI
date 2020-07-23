namespace SMI.Infrastructure.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SMI.Core.Entites;
    class MantenimientoProgramadoConfiguration : IEntityTypeConfiguration<MantenimientoProgramado>
    {
        public void Configure(EntityTypeBuilder<MantenimientoProgramado> builder)
        {
            builder.Property(e => e.FechaEstablecidad).HasColumnType("date");

            builder.Property(e => e.FechaFinProgramada).HasColumnType("date");

            builder.Property(e => e.FechaFinRealizacion).HasColumnType("date");

            builder.Property(e => e.Observaciones)
                .IsUnicode(false)
                .HasDefaultValueSql("('Sin observaciones')");

            builder.HasOne(d => d.IdActividadNavigation)
                .WithMany(p => p.MantenimientoProgramado)
                .HasForeignKey(d => d.IdActividad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SeVaARelizar");

            builder.HasOne(d => d.IdEmpleadoNavigation)
                .WithMany(p => p.MantenimientoProgramado)
                .HasForeignKey(d => d.IdEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("EsAsiganadaA");

            builder.HasOne(d => d.IdEspacioNavigation)
                .WithMany(p => p.MantenimientoProgramado)
                .HasForeignKey(d => d.IdEspacio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SeReaalizaEn");
        }
    }
}
