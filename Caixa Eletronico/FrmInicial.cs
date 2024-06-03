using Caixa_Eletronico.Classes;

namespace Caixa_Eletronico
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void FrmInicial_Load(object sender, EventArgs e)
        {
            Singleton s = Singleton.Instance;

        }

        private void btAdm_Click(object sender, EventArgs e)
        {
            frmAdm adm = new frmAdm();
            adm.Show();
            this.Hide();
        }

        private void FrmInicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btCaixa_Click(object sender, EventArgs e)
        {
            loginConta login = new loginConta();
            login.Show();
            this.Hide();
        }
    }
}
