using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Usuarios
{
    class Usuario_master : Usuario_acesso
    {
        //Usuario unitilizavel, apenas entender a metodologia da interfece
        public Usuario_master(string cpf, string senha):base(cpf, senha) { }
    }
}
