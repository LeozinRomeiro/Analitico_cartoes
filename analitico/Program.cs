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

            Cartao itau = new Cartao();

            itau.nome = "leonardo ferreira";

            

            itau.Creditar(700);

            Console.WriteLine(itau.limite);

            itau.Aumentar(1000);

            Console.WriteLine(itau.limite);
            Console.ReadLine();
            
        }
    }
}
