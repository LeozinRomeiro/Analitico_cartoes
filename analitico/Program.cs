using Analitico.Usuarios;
using Analitico.Pagamento_virtual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario Leonardo = new Usuario(0);

            Leonardo.CPF = "143.526.119-48";
            Leonardo.Nome = "Leonardo Henrique";

            Cartao azul = new Cartao(1559);


            Console.WriteLine(azul.Numero_cartao);


            azul = new Debito(azul.Numero_cartao);

            Console.WriteLine(azul.Numero_cartao);

            Console.ReadLine();
            
        }
    }
}
