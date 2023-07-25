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
        public int Numero_cartao { get; }//Objeto somente leitura 
        //Forma simplificada de criar um get e set
        public string Nome_cartao { get; set; }

        public Cartao(int numero_cartao, int agencia, int numero_conta, string banco) : base(agencia, numero_conta, banco)
        {
            Numero_cartao = numero_cartao;
        }
        public abstract bool Agregar(double valor);//Virtual POSSIBILITA a sobreescreve-lo em uma herança
        public abstract bool Reduzir(double valor);//Marca essa instanci/metodo como abstract OBRIGA a sobreescreva-la em filho
    }
}
