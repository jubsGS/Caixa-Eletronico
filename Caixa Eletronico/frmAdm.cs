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
    public partial class frmAdm : Form
    {

        Singleton s;
        public frmAdm()
        {
            InitializeComponent();
            s = Singleton.Instance; //dessa forma, dentro do nosso formulário, o "s" ira responder ao singleton
        }

        private void frmAdm_Load(object sender, EventArgs e)
        {
            Recarregar();
            btSalvar.Enabled = false;
            btExcluir.Enabled = false;
        }

        public void Recarregar()
        {
            var source = new BindingSource(); //cria uma fonte de dados, onde vc "amarra" uma estrutura de dados com elementos. Forncerá informações para uma tabela
            source.DataSource = s.contas; //a fonte desse banco de dados é a "s.contas" do singleton
            dgvContas.DataSource = source; //dgv = data grid view, irá montar uma tabela e mostrará
        }

        public void LimparCampos()
        {
            txtNumero.Text = "";
            txtNumero.Enabled = true;
            cboxTipo.SelectedIndex = -1;
            cboxTipo.Enabled = true;
            numLimite.Value = 0;
            numSaldo.Value = 0;
            chbEspecial.Checked = false;
            chbStatus.Checked = true;

            btSalvar.Enabled = false;
            btExcluir.Enabled = false;
            btCadastrar.Enabled = true;
        }


        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string numero = txtNumero.Text;

            Conta dup = s.BuscarConta(numero);

            if (dup == null)
            {
                switch (cboxTipo.SelectedIndex)
                {
                    case 0:
                        CCorrente c = new CCorrente(numero, (double)numLimite.Value)
                        {
                            Especial = chbEspecial.Checked,
                        };
                        s.contas.Add(c);
                        break;
                    case 1:
                        s.contas.Add(new CPoupanca(numero));
                        break;
                }

                Recarregar();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Já existe uma conta com esse número!");
            }
        }

        private void frmAdm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cboxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxTipo.SelectedIndex == 1)
            {
                numLimite.Value = 0;
                numLimite.Enabled = false;
                chbEspecial.Enabled = false;
                chbEspecial.Checked = false;
            }
            else
            {
                numLimite.Enabled = true;
                chbEspecial.Enabled = true;
            }
        }

        private void dgvContas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int linha = dgvContas.SelectedCells[0].RowIndex;// retorna o vetor da(s) celula(s) selecionada
                string numero = dgvContas.Rows[linha].Cells[0].Value + ""; // apartir od datagrid ele seleciona aquela linha de indice "linha"

                Conta conta = s.BuscarConta(numero);
                txtNumero.Text = conta.Numero;
                txtNumero.Enabled = false;
                numLimite.Value = (decimal)conta.Limite;
                numSaldo.Value = (decimal)conta.Saldo;
                cboxTipo.Enabled = false; //indica o tipo da conta (corrente || poupança)
                chbStatus.Checked = conta.Status;

                if (conta is CCorrente cc)//por mais que haja uma lista para contas, ele nn adiciona diretamente o elemento à ela. "se a conta é uma conta corrente, irá para lista "cc"
                {
                    cboxTipo.SelectedIndex = 0;
                    chbEspecial.Checked = cc.Especial;
                }
                else
                {
                    cboxTipo.SelectedIndex = 1;
                }

                btCadastrar.Enabled = false;
                btSalvar.Enabled = true;
                btExcluir.Enabled = true;
            }
            catch (Exception ex) { }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Conta c = s.BuscarConta(txtNumero.Text);
            c.Limite = (double)numLimite.Value;
            if (c is CCorrente cc)
            {
                cc.Especial = chbEspecial.Checked;
            }
            MessageBox.Show("Alterado com sucesso!");
            LimparCampos();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            Conta c = s.BuscarConta(txtNumero.Text);
            DialogResult r = MessageBox.Show($"Deseja mesmo excluir a conta número {c.Numero}?", "CTiBank - Confirmação", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                c.Status = false;
                MessageBox.Show("Conta excluída com sucesso");
            }
            Recarregar();
            LimparCampos();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            FrmInicial frm = new FrmInicial();
            frm.Show();
            this.Hide();
        }
    }
}
