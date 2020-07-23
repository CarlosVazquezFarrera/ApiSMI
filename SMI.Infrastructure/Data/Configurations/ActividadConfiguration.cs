namespace SMI.Infrastructure.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SMI.Core.Entites;

    public class ActividadConfiguration : IEntityTypeConfiguration<Actividad>
    {
        public void Configure(EntityTypeBuilder<Actividad> builder)
        {
            builder.Property(e => e.Actividad1)
                   .IsRequired()
                   .HasColumnName("Actividad")
                   .IsUnicode(false);

            builder.HasOne(d => d.IdMantenimientoNavigation)
                .WithMany(p => p.Actividad)
                .HasForeignKey(d => d.IdMantenimiento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PerteneceA");
        }
    }
}
