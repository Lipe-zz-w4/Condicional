namespace Condicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSenha.Clear();
            txtUsuario.Clear();
            txtUsuario.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            string usuario = "fulano.tal";
            string senha = "12345678";

            if (usuario == txtUsuario.Text && senha == txtSenha.Text)
            {
                MessageBox.Show("Bem vindo ao sistema, " + usuario);
            }
            else
            {
                MessageBox.Show("Acesso negado.");
            }
        }
    }
}
