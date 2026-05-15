namespace Condicional
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = "fulano.tal";
            string senha = "Semsenha999@";

            if (usuario == txtUsuario.Text &&
                senha == txtSenha.Text)
            {
                MessageBox.Show("Seja bem-vindo ao nosso sistema, " + usuario);
            }
            else
            {
                MessageBox.Show("Acesso negado!!!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear(); // txtUsuario.Text = "";
            txtSenha.Clear();   // txtSenha.Text = "";
            txtUsuario.Focus();
        }
    }
}
