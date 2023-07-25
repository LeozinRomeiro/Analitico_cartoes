using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analitico.Sistema
{
    public interface Acesso//Interface nao pode ter inplemetação em metodos e tambem nao tem codificadores de visibilidade
    {
        bool Validar(string senha);
    }
}
