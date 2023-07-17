using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Pagamento_virtual
{
    internal class Debito : Cartao
    {
        public Debito(int numero, int agencia, int numero_conta, string banco) : base(numero, agencia, numero_conta, banco)//Na declaração da classe base obriguei um campo que agora é nessario na heranca por essa codifição senelhanca a declaração de heranca
        {
        }


        public override bool Agregar(double valor)
        {
            if (valor < 0)
                return false;
            Saldo += valor; return true;
        }

        public override bool Reduzir(double valor)
        {
            if (valor < 0)
                return false;
            Saldo -= valor; return true;
        }
    }
}
