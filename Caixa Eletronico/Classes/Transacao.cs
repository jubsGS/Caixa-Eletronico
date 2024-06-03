using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa_Eletronico.Classes
{
    public class Transacao
    {
        private double valor;
        private char tipo;
        private Transacao duplicata;
        private Conta conta;

        public double Valor
        {
            get => valor;
        }

        public char Tipo
        {
            get => tipo;
        }

        public Transacao Duplicata
        {
            get => duplicata;
            set => duplicata = value;
        }
        public Conta Conta
        {
            get => conta;
        }

        public Transacao(double valor, char tipo, Conta conta)
        {
            this.valor = valor;
            this.tipo = tipo;
            this.conta = conta;
        }

        public override string ToString()
        {
            return tipo + ", " + valor + ", " + conta;
        }
    }
}
