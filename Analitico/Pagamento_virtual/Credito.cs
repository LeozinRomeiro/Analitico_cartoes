using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Pagamento_virtual
{
    internal class Credito : Cartao //Herança mostrando que o "credito" é um cartao e herdando as variaveis dele
    {
        private double _limite = 1000; //Indicando seu formato private para colocar condições no get e no set
        public DateTime Vencimento { get; set; }

        public Credito(int numero, DateTime vencimento) : base(numero)
        {
            Vencimento = vencimento;
        }


        public double Limite
        {
            get
            {
                return _limite;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _limite = value;
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

        public bool Creditar(double valor)
        {
            if (_limite < valor)//Funcao para credirar os cartões
                return false;
            _limite -= valor; return true;
        }

        public override bool Agregar(double valor)//override indica que essa funcao sobreescreve outra de acordo com a herança
        {
            if (valor < 0)
                return false;
            _limite += valor; return true;
        }

        public bool Reduzir(double valor)
        {
            if (valor < _limite)
                return false;
            _limite -= valor; return true;
        }
    }
}
