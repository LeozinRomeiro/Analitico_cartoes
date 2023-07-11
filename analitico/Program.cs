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
            Conta devedora = new Conta(889,153212,"BB");
            Cartao atual = new Cartao();

            atual.Nome = "leonardo ferreira";
            devedora.Banco = "itau";


            Console.WriteLine(Conta.Total);

            Console.ReadLine();
            
        }
    }
}
