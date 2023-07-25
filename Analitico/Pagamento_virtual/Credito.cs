using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Pagamento_virtual
{
    internal class Credito : Cartao //Herança mostrando que o "credito" é um cartao e herdando as variaveis dele
    {
         //Indicando seu formato private para colocar condições no get e no set
        public DateTime Vencimento { get; set; }

        public Credito(int numero_cartao, DateTime vencimento, int agencia, int numero, string banco) : base(numero_cartao, agencia, numero, banco)
        {
            Vencimento = vencimento;
            Limite = 1000;
        }


        public double Limite
        {
            get
            {
                return Limite;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                Limite = value;
            }
        }

        /*public double Captar_limite()
        {
            return _limite;//GET DA FORMA MAIS BRUTA
        }

        public void Definir_limite(double limite)
        {
            if (limite < 0)//SET DA FORMA BRUTA
                return;
            this._limite = limite;
        }*/

        public bool Creditar(double valor)//Funcao para credirar os cartões
        {
            if (Limite < valor)
                return false;
            Limite -= valor; return true;
        }

        public override bool Agregar(double valor)//override indica que essa funcao sobreescreve outra de acordo com a herança
        {
            if (valor < 0)
                return false;
            Limite += valor; return true;
        }

        public override bool Reduzir(double valor)
        {
            if (valor < Limite)
                return false;
            Limite -= valor; return true;
        }
    }
}
