namespace SMI.Infrastructure.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SMI.Core.Entites;
    class EspacioConfiguration : IEntityTypeConfiguration<Espacio>
    {
        public void Configure(EntityTypeBuilder<Espacio> builder)
        {
            builder.Property(e => e.Ancho)
                  .HasColumnType("decimal(4, 2)")
                  .HasDefaultValueSql("((0.0))");

            builder.Property(e => e.Largo)
                .HasColumnType("decimal(4, 2)")
                .HasDefaultValueSql("((0.0))");

            builder.Property(e => e.Nombre)
                .IsRequired()
                .IsUnicode(false);

            builder.HasOne(d => d.IdEdificioNavigation)
                .WithMany(p => p.Espacio)
                .HasForeignKey(d => d.IdEdificio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SeEncuentraEn");
        }
    }
}
