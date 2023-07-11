using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico
{
    public class Cartao
    {
        public Conta Banco { get; set; }//Forma simplificada de criar um get e set
        public int Numero { get; set; }
        public string Nome { get; set; }

        private double _limite = 1000; //Indicando seu formato private para colocar condições no get e no set

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



        public double Captar_limite()
        {
            return _limite;//Get da forma mais bruta
        }

        public void Definir_limite(double limite)
        {
            if (limite < 0)//Set da forma bruta
                return;
            this._limite = limite;
        }

        public bool Creditar(double valor)
        {
            if (_limite < valor)//Funcao para credirar os cartões
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
            if (valor < _limite)
                return false;
            _limite -= valor; return true;
        }
    }
}
