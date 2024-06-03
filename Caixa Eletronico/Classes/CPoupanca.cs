using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa_Eletronico.Classes
{
    public class CPoupanca : Conta
    {
        public CPoupanca() : base() { }
        public CPoupanca(string numero) : base(numero, 0) { }
    }
}
