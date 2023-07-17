using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Pagamento_virtual
{
    internal abstract class Cartao : Conta
    {
        //public Conta Banco { get; set; } forma de agregar um dado de classe para outra
        public int Numero_cartao { get; private set; }//Forma simplificada de criar um get e set
        public string Nome_cartao { get; set; }

        public Cartao(int numero_cartao, int agencia, int numero, string banco) :base(agencia, numero, banco)
        {
            Numero_cartao=numero;
        }
        public abstract bool Agregar(double valor);//Virtual possibilita a sobreescreve-lo em uma herança
        public abstract bool Reduzir(double valor);//Marca essa instanci/metodo como abstract obria a sobreescreva-la em filho
    }
}
