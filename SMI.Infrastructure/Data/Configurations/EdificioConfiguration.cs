namespace SMI.Infrastructure.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SMI.Core.Entites;
    class EdificioConfiguration : IEntityTypeConfiguration<Edificio>
    {
        public void Configure(EntityTypeBuilder<Edificio> builder)
        {
            builder.Property(e => e.Ancho)
                    .HasColumnType("decimal(4, 2)")
                    .HasDefaultValueSql("((0.0))");

            builder.Property(e => e.FechaEdificacion).HasColumnType("date");

            builder.Property(e => e.Largo)
                .HasColumnType("decimal(4, 2)")
                .HasDefaultValueSql("((0.0))");

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
