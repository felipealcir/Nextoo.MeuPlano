using System;
using System.Collections.Generic;
using System.Text;
using Wooza.MeuPlano.Dominio.Planos.Enumerable;

namespace Wooza.MeuPlano.Dominio.Planos
{
    public class Plano
    {
        public int CodigoPlano { get; set; }

        public int Minutos { get; set; }

        public int FranquiaDeInternet { get; set; }

        public int Valor { get; set; }

        public TipoDePlano Tipo { get; set; }

        public string Operadora { get; set; }
    }
}
