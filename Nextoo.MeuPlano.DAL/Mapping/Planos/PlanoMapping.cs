using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nextoo.MeuPlano.DAL.Extensions;
using Nextoo.MeuPlano.Dominio.Planos;

namespace Nextoo.MeuPlano.DAL.Mapping.Planos
{
    public class PlanoMapping : EntityTypeConfiguration<Plano>
    {
        public override void Map(EntityTypeBuilder<Plano> builder)
        {
            throw new NotImplementedException();
        }
    }
}
