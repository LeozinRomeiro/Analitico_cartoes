using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cartao itau = new cartao();

            itau.nome = "leonardo ferreira";

            itau.Creditar(700);

            Console.WriteLine(itau.limite);
            Console.ReadLine();
        }
    }
}
