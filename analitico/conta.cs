using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico
{
    public class Conta
    {
        public string Banco { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public static int Total { get; private set; }

        public Conta(int agencia, int numero, string banco) 
        {
            Agencia = agencia; Numero = numero; Banco = banco;//Obrigar o dev a informar os criterios qunando acionar o objeto
            Total++;
        }
    }
}
