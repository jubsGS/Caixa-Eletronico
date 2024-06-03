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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Caixa_Eletronico
{
    public partial class loginConta : Form
    {
        public loginConta()
        {
            InitializeComponent();
        }

        private void btAcessar_Click(object sender, EventArgs e)
        {
            string numero = tbConta.Text;
            Conta procura = Singleton.Instance.BuscarConta(numero);
            if (procura != null )
            {
                telaPrincipal opcoes = new telaPrincipal(procura);
                opcoes.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Não foi possivel encontrar essa conta. Tente novamente verificando os digitos.");
            }
        }
    }
}
