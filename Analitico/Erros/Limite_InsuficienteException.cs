using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Erros
{
    internal class Limite_InsuficienteException : Exception
    {
        public Limite_InsuficienteException() { }
        public Limite_InsuficienteException(string message) : base(message) { }//Mandamos para classe pae para sobreescrever a variavel messagem, sem isso o .messagem será a do sistema
        public Limite_InsuficienteException(double limite, double valor) 
            : this("Limite insuficiente! seu limite atual é"+limite+"inferior ao valor de"+valor) { }
    }
}
