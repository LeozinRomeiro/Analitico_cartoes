using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico
{
    class Validar_helper//indique Internal class que utileza somente dentro da sua biblioteca; nao indicar o visi
    {
        public bool Validar(string senha, string senha_tentativa)
        {
            return senha == senha_tentativa;
        }
    }
}
