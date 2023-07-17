using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Pagamento_virtual
{
    internal class Conta
    {
        public string Banco { get; set; }
        public int Agencia { get; set; }
        public int Numero_conta { get; set; }
        public double Saldo
        {
            get
            {
                return Saldo;
            }
            protected set//Protected é outro modificador de segurança, esse limita a utilização da variavel dentro do objeto e seus filhos
            {
                if (value > 0)
                    Saldo = value;
                return;
            }
        }
        public static int Total { get; private set; } //static implica que essa variavel se referencia a toda e classe e não apenas para um simples objeto

        public Conta(int agencia, int numero_conta, string banco)
        {
            Agencia = agencia; Numero_conta = numero_conta; Banco = banco;//Obrigar o dev a informar os criterios qunando acionar o objeto
            Total++;
        }
    }
}
