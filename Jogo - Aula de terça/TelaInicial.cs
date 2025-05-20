using System;
using System.Windows.Forms;

namespace Jogo___Aula_de_terça
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Por favor, digite seu nome para iniciar o jogo.");
                return;
            }

            Form1 jogo = new Form1(nome);
            jogo.Show();
            this.Hide();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            // Pode ser usado para configurações futuras
        }
    }
}
