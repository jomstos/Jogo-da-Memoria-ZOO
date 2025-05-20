namespace Jogo___Aula_de_terça
{
    partial class TelaInicial
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            btnIniciar = new Button();
            txtNome = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Font = new Font("Broadway", 25.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(127, 71);
            label1.Name = "label1";
            label1.Size = new Size(582, 50);
            label1.TabIndex = 0;
            label1.Text = "Jogo Da Memória - ZOO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnIniciar
            // 
            btnIniciar.Anchor = AnchorStyles.None;
            btnIniciar.BackColor = Color.Green;
            btnIniciar.Font = new Font("Broadway", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.ForeColor = Color.Black;
            btnIniciar.Location = new Point(286, 235);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(228, 59);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(255, 224, 192);
            txtNome.Location = new Point(378, 186);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(183, 27);
            txtNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(139, 187);
            label2.Name = "label2";
            label2.Size = new Size(233, 26);
            label2.TabIndex = 3;
            label2.Text = "Digite seu nome:";
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = Properties.Resources.cartaVirada;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(btnIniciar);
            Controls.Add(label1);
            Name = "TelaInicial";
            Text = "Tela Inicial";
            Load += TelaInicial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnIniciar;
        private TextBox txtNome;
        private Label label2;
    }
}
