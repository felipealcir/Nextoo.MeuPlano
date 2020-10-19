using Nextoo.MeuPlano.DAL.Commom;
using Nextoo.MeuPlano.DAL.Connection;
using Nextoo.MeuPlano.DAL.Repository.Planos.IRepository;
using Nextoo.MeuPlano.Dominio.Planos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nextoo.MeuPlano.DAL.Repository.Planos
{
    public class PlanoRepository : Repository<Plano>, IPlanoRepository
    {
        public PlanoRepository(ConnectionContext context)
            : base(context)
        {

        }
    }
}
