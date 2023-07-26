using Analitico.Usuarios;
using Analitico.Pagamento_virtual;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Analitico.Sistema;

namespace Analitico
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cadastrar();//Irelevante, os metodos nao tras algo criado dentro dele

            Console.ReadLine();

        }
        public static void Cadastrar()
        {
            try
            {
                Debito conta_leonardo = new Debito(9395, 4545, 2407, "BB");
            }
            catch
            {

            }

            Usuario_responsavel Leonardo = new Usuario_responsavel("143", "123");


            DateTime variavel = new DateTime(2011, 7, 10);
            Console.WriteLine("Today is " + variavel.ToString("MM/yy") + ".");

            Credito roxo = new Credito(9395, variavel, 213, 2568, "NuBank");
        }
    }
}
