using Analitico.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Sistema
{
    public class Autenticador : Usuario
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

        public bool Agregar(double valor)
        {
            if (valor < 0)
                return false;
            this.Senha += valor; return true;
        }
    }
}
