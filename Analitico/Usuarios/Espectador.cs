using Analitico.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Usuarios
{
    internal class Espectador : Acesso
    {
        public string Senha { get; }
        bool Acesso.Validar(string senha)
        {
            return Senha == senha;
        }
    }
}
