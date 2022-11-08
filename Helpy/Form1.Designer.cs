namespace Helpy
{
    partial class Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.butCad = new System.Windows.Forms.Button();
            this.butLogin = new System.Windows.Forms.Button();
            this.senha = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.TextBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // butCad
            // 
            this.butCad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCad.FlatAppearance.BorderSize = 0;
            this.butCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butCad.Location = new System.Drawing.Point(513, 432);
            this.butCad.Name = "butCad";
            this.butCad.Size = new System.Drawing.Size(239, 61);
            this.butCad.TabIndex = 4;
            this.butCad.UseVisualStyleBackColor = true;
            this.butCad.Click += new System.EventHandler(this.butCad_Click);
            // 
            // butLogin
            // 
            this.butLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.butLogin.FlatAppearance.BorderSize = 0;
            this.butLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.butLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLogin.Location = new System.Drawing.Point(58, 432);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(179, 61);
            this.butLogin.TabIndex = 0;
            this.butLogin.UseVisualStyleBackColor = true;
            this.butLogin.Click += new System.EventHandler(this.Button2_Click);
            // 
            // senha
            // 
            this.senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.senha.Location = new System.Drawing.Point(451, 372);
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(375, 25);
            this.senha.TabIndex = 9;
            this.senha.Text = "Senha";
            this.senha.Click += new System.EventHandler(this.senha_Click);
            // 
            // telefone
            // 
            this.telefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.telefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.telefone.Location = new System.Drawing.Point(451, 290);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(375, 25);
            this.telefone.TabIndex = 10;
            this.telefone.Text = "Telefone";
            this.telefone.Click += new System.EventHandler(this.telefone_Click);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.email.Location = new System.Drawing.Point(451, 211);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(375, 25);
            this.email.TabIndex = 11;
            this.email.Text = "Email";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // usuario
            // 
            this.usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.usuario.Location = new System.Drawing.Point(451, 131);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(386, 25);
            this.usuario.TabIndex = 12;
            this.usuario.Text = "Nome de usuário";
            this.usuario.Click += new System.EventHandler(this.usuario_Click_1);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Helpy.User);
            // 
            // Cadastro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.email);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.butCad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cadastro_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butCad;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}

