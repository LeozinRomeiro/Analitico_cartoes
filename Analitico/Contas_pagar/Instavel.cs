using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Contas_pagar
{
    internal class Instavel : Despesa
    {
        public DateTime Data_emissao { get; }

        public DateTime Data_fim { get; }

        public Instavel(DateTime data_emissao, DateTime data_fim, double valor, DateTime data_pagamento, string motivo) : base(valor, data_pagamento, motivo)
        {
            Data_emissao = data_emissao; Data_fim = data_fim;
        }
    }
}
