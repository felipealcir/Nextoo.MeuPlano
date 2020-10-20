using System;
using System.Collections.Generic;
using System.Text;
using Nextoo.MeuPlano.Dominio.Planos.Enumerable;

namespace Nextoo.MeuPlano.Dominio.Planos
{
    public class Plano
    {
        public decimal? CodigoPlano { get; set; }

        public decimal Minutos { get; set; }

        public decimal FranquiaDeInternet { get; set; }

        public float Valor { get; set; }

        public string Tipo { get; set; }

        public string Operadora { get; set; }

        public string DDD { get; set; }
    }
}
