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
            if (senha == "21432")
            {
                return true;
            }
            return false;
        }

        public bool Agregar(double valor)
        {
            if (valor < 0)
                return false;
            this.Senha += valor; return true;
        }
    }
    public class Internal
    {
        public bool Logar(Usuario usuario, string senha)
        {
            bool resposta = false;
            if (resposta)
            {
                Console.WriteLine("Certo");
            }
            Console.WriteLine("Erro"); return false;
        }
    }
}
