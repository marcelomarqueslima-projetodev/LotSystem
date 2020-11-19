using LotSystemAdmDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LotSystemAdmInfraData.Mapping
{
    public class EstadoMapping : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("Estado");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.NomeEstado)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("NomeEstado");

            builder.Property(c => c.SiglasEstado)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("SiglaEstado");
        }
    }
}
