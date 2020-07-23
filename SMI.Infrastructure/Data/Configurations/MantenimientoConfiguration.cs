namespace SMI.Infrastructure.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SMI.Core.Entites;
    class MantenimientoConfiguration : IEntityTypeConfiguration<Mantenimiento>
    {
        public void Configure(EntityTypeBuilder<Mantenimiento> builder)
        {
            builder.Property(e => e.Mantenimiento1)
                       .IsRequired()
                       .HasColumnName("Mantenimiento")
                       .IsUnicode(false);
        }
    }
}
