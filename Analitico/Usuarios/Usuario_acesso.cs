using Analitico.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Usuarios
{
    abstract class Usuario_acesso : Usuario, Acesso//Criamos uma classe especifica para usuario que tem acesso para evitar repetição de codigo
    {
        string Senha { get;}
        public bool Validar(string senha)
        {
            return Senha == senha;
        }
    }
}
