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
        private Validar_helper _validar_helper;
        public string Senha { get; }
        bool Acesso.Validar(string senha)
        {
            return _validar_helper.Validar(Senha, senha);
        }
    }
}
