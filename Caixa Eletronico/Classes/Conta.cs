using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa_Eletronico.Classes
{
    public abstract class Conta
    {
        protected string numero;
        protected double saldo;
        protected double limite;
        protected bool status;
        protected List<Transacao> transacoes;

        public string Numero
        {
            get => numero;
            set => numero = value;
        }
        public double Saldo
        {
            get => saldo;
        }
        public double Limite
        {
            get => limite;
            set => limite = value;
        }
        public bool Status
        {
            get => status;
            set => status = value;
        }

        public List<Transacao> Transacoes
        {
            get => transacoes;
        }

        public Conta()
        {
            saldo = 0;
            status = true;
            transacoes = new List<Transacao>();
        }

        public Conta(string numero, double limite) : this()
        {
            this.numero = numero;
            this.limite = limite;
        }

        public bool Sacar(double valor)
        {
            if (status && saldo - valor >= -limite)
            {
                saldo -= valor;
                transacoes.Add(new Transacao(valor, 'S', this));
                return true;
            }
            return false;
        }

        public bool Sacar(double valor, out Transacao? t)
        {
            if (Sacar(valor))
            {
                t = transacoes[transacoes.Count - 1];
                return true;
            }
            t = null;
            return false;
        }

        public bool Depositar(double valor)
        {
            if (status && valor > 0)
            {
                saldo += valor;
                transacoes.Add(new Transacao(valor, 'D', this));
                return true;
            }
            return false;
        }

        public bool Depositar(double valor, out Transacao? t)
        {
            if (Depositar(valor))
            {
                t = transacoes[transacoes.Count - 1];
                return true;
            }
            t = null;
            return false;
        }

        public bool Transferir(Conta destino, double valor)
        {
            Transacao? saque, deposito;
            if (destino.status &&
                Sacar(valor, out saque) &&
                destino.Depositar(valor, out deposito) &&
                saque != null && deposito != null)
            {
                saque.Duplicata = deposito;
                deposito.Duplicata = saque;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return numero;
        }
    }
}
