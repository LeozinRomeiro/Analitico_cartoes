using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Pagamento_virtual
{
    internal abstract class Conta//abstract indica que essa classe so é criada apartir de outras, ela so alimeta outras e dissuardi a crição invidual da mesma
    {
        public string Banco { get; }
        public int Agencia { get; }
        public int Numero_conta { get; }
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
            if (agencia <= 0)
            {
                throw new ArgumentException("Erro no " + nameof(agencia));
            }
            if (numero_conta <= 0)
            {
                throw new ArgumentException("Erro no " + nameof(numero_conta));
            }
            Agencia = agencia; Numero_conta = numero_conta; Banco = banco;//Obrigar o dev a informar os criterios qunando acionar o objeto
            Total++;
        }

    }
}
