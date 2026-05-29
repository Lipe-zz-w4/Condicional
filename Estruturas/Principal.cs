using System;
using System.Text;

namespace Estruturas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            string usuario = "admin";
            string senha = "Tente123@";

            if (usuario == txtUsuario.Text & senha == txtSenha.Text)
            {
                frmCadastro cadastro = new frmCadastro();
                cadastro.FormBorderStyle = FormBorderStyle.None;
                cadastro.Bounds = Screen.PrimaryScreen.Bounds;
                cadastro.TopMost = true;
                cadastro.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!!", "Verificação",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
                txtUsuario.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            // Laço de repetição que testa a condição no início
            int i = 9;
            int num = 0;
            lsbMostra.Items.Clear();

            // while (condição for verdadeira) {faça}

            while (num <= 10)
            {
                lsbMostra.Items.Add(i + "x" + num + " = " + num*i);
                num++;
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int i = 6;
            int num = 0;
            lsbMostra.Items.Clear();
            // testa a condição no final
            do
            {
                lsbMostra.Items.Add(i + "x" + num + " = " + num * i);
                num++;
            }
            while (num <= 10);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            lsbMostra.Items.Clear();

            // utilização de matriz para desenhar um quadrado

            int tamanho = 5;
            char[,] matriz = new char[tamanho, tamanho];
            // [,] define a variavel como uma matriz.

            // utilizar duas funcoes FOR, uma checando a coordenada X e outra a coordenada Y
            for (int x = 0; x < tamanho; x++) { 
                for (int y = 0; y < tamanho; y++) {

                    matriz[x, y] = '#';

                }
            }

            /*
             para imprimir um resultado em uma lista, é necessario criar uma
            string.
            Usar a função string builder
            */

            for (int x = 0; x < tamanho; x++)
            {
                // criar linha por linha (x) para imprimir o quadrado
                StringBuilder linha = new StringBuilder();

                for (int y = 0; y < tamanho; y++)
                {
                    linha.Append(matriz[x, y]);

                }
            }



            //

        }

        private void btnForEach_Click(object sender, EventArgs e)
        {

        }
    }
}
