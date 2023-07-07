using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste;

namespace Analitico
{
    public class cartao
    {
        public Teste.Conta conta;
        public int numero;
        public int cvc;
        public string nome;
        public double limite=1000;

        public bool Creditar(double valor)
        {
            if (this.limite < valor)
                return false;
            this.limite -= valor; return true;
        }

        public bool Aumentar(double valor)
        {
            if (valor < 0)
                return false;
            this.limite += valor; return true;
        }

        public bool Diminuir(double valor)
        {
            if(valor<this.limite)
                return false;
            this.limite -= valor; return true;
        }
    }
}
