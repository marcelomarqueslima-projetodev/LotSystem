using LotSystemAdmDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LotSystemAdmInfraData.Mapping
{
    public class PaisMapping : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.ToTable("Pais");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.NomePais)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("NomePais");

            builder.Property(c => c.SiglaPais)
                .IsRequired()
                .HasMaxLength(3)
                .HasColumnName("SiglaPais");
        }
    }
}
