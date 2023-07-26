using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Usuarios
{
    internal class Usuario_responsavel : Usuario_acesso
    {
        public Usuario_responsavel(string cpf, string senha) : base(cpf, senha) { }
    }
}
