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
            Conta devedora = new Conta();
            Cartao atual = new Cartao();

            atual.nome = "leonardo ferreira";
            devedora.banco = "itau";

            Console.ReadLine();
            
        }
    }
}
