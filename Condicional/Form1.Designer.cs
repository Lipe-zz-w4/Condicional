namespace Condicional
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEntrar = new Button();
            panel1 = new Panel();
            btnLimpar = new Button();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(34, 126);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(112, 34);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnEntrar);
            panel1.Location = new Point(250, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 500);
            panel1.TabIndex = 2;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(247, 126);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(112, 34);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(145, 12);
            txtUsuario.MaxLength = 40;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(273, 31);
            txtUsuario.TabIndex = 5;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(145, 55);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(273, 31);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 61);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 15);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 655);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEntrar;
        private Panel panel1;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label label2;
        private Label label1;
        private Button btnLimpar;
    }
}
