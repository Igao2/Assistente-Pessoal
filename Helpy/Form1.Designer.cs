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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.usuario = new System.Windows.Forms.RichTextBox();
            this.butCad = new System.Windows.Forms.Button();
            this.butLogin = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.RichTextBox();
            this.telefone = new System.Windows.Forms.RichTextBox();
            this.senha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuario.EnableAutoDragDrop = true;
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.usuario.Location = new System.Drawing.Point(451, 129);
            this.usuario.Multiline = false;
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(375, 28);
            this.usuario.TabIndex = 1;
            this.usuario.Text = "Nome de usuário";
            this.usuario.Click += new System.EventHandler(this.Usuario_Click);
            // 
            // butCad
            // 
            this.butCad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butCad.Location = new System.Drawing.Point(531, 424);
            this.butCad.Name = "butCad";
            this.butCad.Size = new System.Drawing.Size(200, 39);
            this.butCad.TabIndex = 4;
            this.butCad.UseVisualStyleBackColor = true;
            // 
            // butLogin
            // 
            this.butLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.butLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.butLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLogin.Location = new System.Drawing.Point(69, 433);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(149, 39);
            this.butLogin.TabIndex = 0;
            this.butLogin.UseVisualStyleBackColor = true;
            this.butLogin.Click += new System.EventHandler(this.Button2_Click);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.EnableAutoDragDrop = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.email.Location = new System.Drawing.Point(451, 209);
            this.email.Multiline = false;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(375, 25);
            this.email.TabIndex = 6;
            this.email.Text = "Email";
            this.email.Click += new System.EventHandler(this.RichTextBox4_Click);
            // 
            // telefone
            // 
            this.telefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefone.EnableAutoDragDrop = true;
            this.telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.telefone.Location = new System.Drawing.Point(451, 286);
            this.telefone.Multiline = false;
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(375, 29);
            this.telefone.TabIndex = 7;
            this.telefone.Text = "Telefone";
            this.telefone.Click += new System.EventHandler(this.RichTextBox5_Click);
            // 
            // senha
            // 
            this.senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.senha.Location = new System.Drawing.Point(451, 365);
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(375, 24);
            this.senha.TabIndex = 9;
            this.senha.Text = "Senha";
            this.senha.Click += new System.EventHandler(this.senha_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.butCad);
            this.Controls.Add(this.usuario);
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox usuario;
        private System.Windows.Forms.Button butCad;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.RichTextBox email;
        private System.Windows.Forms.RichTextBox telefone;
        private System.Windows.Forms.TextBox senha;
    }
}

