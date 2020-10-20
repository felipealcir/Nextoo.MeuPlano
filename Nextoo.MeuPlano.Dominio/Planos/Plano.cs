using System;
using System.Collections.Generic;
using System.Text;
using Nextoo.MeuPlano.Dominio.Planos.Enumerable;

namespace Nextoo.MeuPlano.Dominio.Planos
{
    public class Plano
    {
        public int CodigoPlano { get; set; }

        public decimal Minutos { get; set; }

        public decimal FranquiaDeInternet { get; set; }

        public decimal Valor { get; set; }

        public string Tipo { get; set; }

        public string Operadora { get; set; }
    }
}
