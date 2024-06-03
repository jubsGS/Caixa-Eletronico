using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Caixa_Eletronico.Classes
{
    public class CCorrente : Conta
    {
        private bool especial;

        public bool Especial
        {
            get => especial;
            set => especial = value;
        }

        public CCorrente() : base() { }

        public CCorrente(string numero, double limite) : base(numero, limite) { }
    }
}
