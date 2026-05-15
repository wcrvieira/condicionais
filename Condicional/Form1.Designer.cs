namespace Condicional
{
    partial class frmPrincipal
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
            btnLimpar = new Button();
            btnEntrar = new Button();
            lblUsuario = new Label();
            lblSenha = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 12F);
            btnLimpar.Location = new Point(176, 156);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(105, 41);
            btnLimpar.TabIndex = 0;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI", 12F);
            btnEntrar.Location = new Point(49, 156);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(110, 41);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F);
            lblUsuario.Location = new Point(49, 37);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(64, 21);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 12F);
            lblSenha.Location = new Point(49, 102);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(53, 21);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(131, 37);
            txtUsuario.MaxLength = 20;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(150, 29);
            txtUsuario.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 12F);
            txtSenha.Location = new Point(131, 99);
            txtSenha.MaxLength = 40;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(150, 29);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 265);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(btnEntrar);
            Controls.Add(btnLimpar);
            Name = "frmPrincipal";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpar;
        private Button btnEntrar;
        private Label lblUsuario;
        private Label lblSenha;
        private TextBox txtUsuario;
        private TextBox txtSenha;
    }
}
