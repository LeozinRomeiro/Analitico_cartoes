using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Contas_pagar
{
    abstract class Despesa
    {
        public double Valor { get; }
        public DateTime Data_pagamento { get; private set; }
        public string Motivo { get; }
        public string Descricao { get; set; }

        public Despesa(double valor, DateTime data_pagamento, string motivo)
        {
            Valor = valor; Data_pagamento=data_pagamento; Motivo = motivo;
        }
    }
}
