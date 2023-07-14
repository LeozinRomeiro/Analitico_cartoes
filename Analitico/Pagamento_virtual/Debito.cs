using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Pagamento_virtual
{
    internal class Debito : Cartao
    {
        public double Saldo
        {
            get
            {
                return Saldo;
            }
            private set
            {
                if (value > 0)
                    Saldo = value;
                return;
            }
        }

        public Debito(int numero) : base(numero)//Na declaração da classe base obriguei um campo que agora é nessario na heranca por essa codifição senelhanca a declaração de heranca
        {
        }

        public override bool Agregar(double valor)
        {
            if (valor < 0)
                return false;
            Saldo += valor; return true;
        }

        public bool Reduzir(double valor)
        {
            if (valor < 0)
                return false;
            Saldo -= valor; return true;
        }
    }
}
