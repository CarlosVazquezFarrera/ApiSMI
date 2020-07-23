namespace SMI.Infrastructure.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using SMI.Core.Entites;
    class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

            builder.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('Sin Email')");

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            builder.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.Telefono)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasDefaultValueSql("('Sin Numero')");
        }
    }
}
