using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Jogo___Aula_de_terça
{
    public partial class Form1 : Form
    {
        private int cliques = 0;
        private readonly Random random = new Random();
        private readonly List<string> icons = new List<string>()
        {
            "🐶", "🐶", "🐱", "🐱", "🦁", "🦁", "🐵", "🐵",
            "🐘", "🐘", "🦓", "🦓", "🦒", "🦒", "🦍", "🦍"
        };

        private Label firstClicked = null;
        private Label secondClicked = null;
        private readonly string nomeDoJogador;

        public Form1(string nome)
        {
            InitializeComponent();
            nomeDoJogador = string.IsNullOrWhiteSpace(nome) ? "Jogador Anônimo" : nome;

            timer1.Tick += timer1_Tick;
            AssignIconsToSquare();
        }

        private void AssignIconsToSquare()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Label iconLabel)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    iconLabel.Font = new Font("Segoe UI Emoji", 32, FontStyle.Regular);
                    iconLabel.TextAlign = ContentAlignment.MiddleCenter;

                    iconLabel.Click += label1_Click;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled) return;

            if (sender is not Label clickedLabel || clickedLabel.ForeColor == Color.Black)
                return;

            cliques++;
            lblCliques.Text = $"Cliques: {cliques}";

            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;
                return;
            }

            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
                CheckForWinner();
            }
            else
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked = null;
            secondClicked = null;
        }

        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Label iconLabel && iconLabel.ForeColor == iconLabel.BackColor)
                    return;
            }

            MessageBox.Show($"{nomeDoJogador}, você combinou todos os pares! 🎉\nTotal de cliques: {cliques}");
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Se necessário, lógica de carregamento
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }
    }
}
