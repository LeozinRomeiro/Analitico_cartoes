using Analitico.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Usuarios
{
    public abstract class Usuario
    {
        public string Nome { get; set; }
        public string CPF { get;}
        public int Numero_telefone { get; set; }

        /*// 0 - Eu
        // 1 - Familia
        // 2 - Amigos
        // N - ...
        private int _tipo { get; set; }//Nivel de proteção private para o uso ficar restrito aqui

        public Usuario(int tipo)//Solicita um campo para criação do usuario
        {
            _tipo = tipo;
        }
        */
    }
}
