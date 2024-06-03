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
    public partial class consultarExtrato : Form
    {
        public consultarExtrato(Conta conta)
        {
            InitializeComponent();

            var source = new BindingSource(); //cria uma fonte de dados, onde vc "amarra" uma estrutura de dados com elementos. Forncerá informações para uma tabela
            source.DataSource = conta.Transacoes; //a fonte desse banco de dados é a "s.contas" do singleton
            dgvExtrato.DataSource = source; //dgv = data grid view, irá montar uma tabela e mostrará
        }
    }
}
