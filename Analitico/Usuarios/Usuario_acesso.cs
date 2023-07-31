using Analitico.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Usuarios
{
    abstract class Usuario_acesso : Usuario, Acesso//Criamos uma classe especifica para usuario que tem acesso para evitar repetição de codigo
    {//Deixei esse usuario acesso para concatenar a classe usuario mais a classe acesso e distribuir sem repetir codigo
        private Validar_helper _validar_helper;
        string Senha { get;}
        public Usuario_acesso(string cpf, string senha):base(cpf)
        {
            Senha = senha;
        }

        public bool Validar(string senha)
        {
            return _validar_helper.Validar(Senha, senha);
        }
    }
}
