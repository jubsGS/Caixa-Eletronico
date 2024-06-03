using Caixa_Eletronico.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_Eletronico
{
    public partial class telaPrincipal : Form
    {
        Conta conta;
        public telaPrincipal(Conta conta)
        {
            InitializeComponent();
            this.conta = conta;
            lblSaldo.Text = conta.Saldo.ToString("c");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            FrmInicial inicial = new FrmInicial();
            inicial.Show();
            this.Hide();
        }

        private void btDepositar_Click(object sender, EventArgs e)
        {
            Operacao oper = new Operacao(conta, 'd');
            oper.ShowDialog();

            lblSaldo.Text = conta.Saldo.ToString("c");
        }

        private void btTransferir_Click(object sender, EventArgs e)
        {
            Operacao oper = new Operacao(conta, 't');
            oper.ShowDialog();

            lblSaldo.Text = conta.Saldo.ToString("c");
        }

        private void btSacar_Click(object sender, EventArgs e)
        {
            Operacao oper = new Operacao(conta, 's');
            oper.ShowDialog();

            lblSaldo.Text = conta.Saldo.ToString("c");
        }

        private void btVerExtrato_Click(object sender, EventArgs e)
        {
            consultarExtrato verExt = new consultarExtrato(conta);
            verExt.ShowDialog();
        }
    }
}
