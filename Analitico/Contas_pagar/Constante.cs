using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Contas_pagar
{
    internal class Constante : Despesa
    {
        public Constante(double valor, DateTime data_pagamento, string motivo) : base(valor, data_pagamento, motivo)
        {

        }
    }
}
