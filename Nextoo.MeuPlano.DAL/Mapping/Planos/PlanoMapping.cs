using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nextoo.MeuPlano.DAL.Extensions;
using Nextoo.MeuPlano.Dominio.Planos;

namespace Nextoo.MeuPlano.DAL.Mapping.Planos
{
    public class PlanoMapping : EntityTypeConfiguration<Plano>
    {
        public override void Map(EntityTypeBuilder<Plano> builder)
        {
            builder.HasKey(e => e.CodigoPlano)
                .HasName("CodigoPlano");

            builder.Property(e => e.FranquiaDeInternet)
                .HasColumnName("FranquiaInternet")
                .HasMaxLength(18)
                .IsRequired();

            builder.Property(e => e.Minutos)
                .HasColumnName("Minutos")
                .HasMaxLength(18)
                .IsRequired();

            builder.Property(e => e.Valor)
                .HasColumnName("Valor")
                .HasMaxLength(18)
                .IsRequired();

            builder.Property(e => e.Tipo)
                .HasColumnName("Tipo")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.Operadora)
                .HasColumnName("Operadora")
                .HasMaxLength(50)
                .IsRequired();

            builder.ToTable("Planos");
        }
    }
}
