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
    public partial class Operacao : Form
    {
        Conta conta;
        public Operacao(Conta conta, char oper)
        {
            InitializeComponent();
            tbContaDest.Hide(); lblContaDest.Hide();
            this.conta = conta;
            switch (oper)
            {
                case 's':
                    lblTipo.Text = "Sacar";
                    break;
                case 'd':
                    lblTipo.Text = "Depositar";
                    break;
                case 't':
                    lblTipo.Text = "Transferir";
                    tbContaDest.Show(); 
                    lblContaDest.Show();
                    break;
            }
        }

        private void btRealizar_Click(object sender, EventArgs e)
        {
            if (lblTipo.Text=="Depositar")
            {
                if (conta.Depositar((double)NUDValor.Value))
                    MessageBox.Show("Sucesso");
                else
                    MessageBox.Show("Não foi possvel efetuar a operação.");
            }

            if (lblTipo.Text == "Sacar")
            {
                if (conta.Sacar((double)NUDValor.Value))
                    MessageBox.Show("Sucesso");
                else
                    MessageBox.Show("Não foi possvel efetuar a operação.");
            }

            Conta cDestino = Singleton.Instance.BuscarConta(tbContaDest.Text);
            if (lblTipo.Text == "Transferir" && cDestino!=null)
            {
                if (conta.Transferir(cDestino, (double)NUDValor.Value))
                    MessageBox.Show("Sucesso");
                else
                    MessageBox.Show("Não foi possvel efetuar a operação. Verifique as informações inseridas.");
            }
        }
    }
}
