﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Pagamento_virtual
{
    internal class Cartao : Conta
    {
        //public Conta Banco { get; set; } forma de agregar um dado de classe para outra
        public int Numero_cartao { get; private set; }//Forma simplificada de criar um get e set
        public string Nome { get; set; }

        public Cartao(int numero_cartao, int agencia, int numero, string banco) :base(agencia, numero, banco)
        {
            Numero_cartao=numero;
        }

        public virtual bool Agregar(double valor)//Virtual possibilita a sobreescreve-lo em uma herança
        {
            return false;
        }
    }
}
