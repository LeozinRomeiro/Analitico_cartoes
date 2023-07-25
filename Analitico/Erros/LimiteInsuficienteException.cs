using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Erros
{
    internal class LimiteInsuficienteException : Exception
    {
        public LimiteInsuficienteException() { }
        public LimiteInsuficienteException(string message) : base(message) { }
        public LimiteInsuficienteException(double limite, double valor) 
            : this("Limite insuficiente! seu limite atual é"+limite+"inferior ao valor de"+valor) { }
    }
}
