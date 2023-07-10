using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico
{
    public class Cartao
    {
        public Conta banco;
        public int numero;
        public string nome;
        private double _limite=1000;

        public double Limite    
        {
            get
            {
                return _limite;
            }
            set
            {
                if (value <0)
                {
                    return;
                }
                _limite = value;
            }
        }

        public double Captar_limite()
        {
            return _limite;
        }

        public void Definir_limite(double limite)
        {
            if( limite < 0 )
                return;
            this._limite = limite;
        }

        public bool Creditar(double valor)
        {
            if (_limite < valor)
                return false;
            _limite -= valor; return true;
        }

        public bool Aumentar(double valor)
        {
            if (valor < 0)
                return false;
            _limite += valor; return true;
        }

        public bool Diminuir(double valor)
        {
            if(valor<_limite)
                return false;
            _limite -= valor; return true;
        }
    }
}
