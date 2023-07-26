using Analitico.Usuarios;
using Analitico.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Sistema
{
    public class Internal
    {
        public bool Logar(Acesso usuario, string senha)//Notamos qur o logar requisita apenas usuarios do tipo acesso
        {
            bool resposta = usuario.Validar(senha);//Essa funcao so pode ser chamada porque é requisitada no "Logar"

            if (resposta)
            {
                Console.WriteLine("Certo");
            }
            Console.WriteLine("Erro");return false;
        }
    }
}
