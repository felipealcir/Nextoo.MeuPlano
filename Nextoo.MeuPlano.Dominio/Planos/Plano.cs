using System;
using System.Collections.Generic;
using System.Text;
using Nextoo.MeuPlano.Dominio.Planos.Enumerable;

namespace Nextoo.MeuPlano.Dominio.Planos
{
    public class Plano
    {
        public int CodigoPlano { get; set; }

        public int Minutos { get; set; }

        public int FranquiaDeInternet { get; set; }

        public double Valor { get; set; }

        public TipoDePlano Tipo { get; set; }

        public string Operadora { get; set; }
    }
}
