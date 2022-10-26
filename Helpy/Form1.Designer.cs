namespace Helpy
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.usuario = new System.Windows.Forms.RichTextBox();
            this.butCad = new System.Windows.Forms.Button();
            this.butLogin = new System.Windows.Forms.Button();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
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
            this.usuario.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
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
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.EnableAutoDragDrop = true;
            this.richTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.richTextBox4.Location = new System.Drawing.Point(451, 209);
            this.richTextBox4.Multiline = false;
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(375, 25);
            this.richTextBox4.TabIndex = 6;
            this.richTextBox4.Text = "Email";
            this.richTextBox4.Click += new System.EventHandler(this.RichTextBox4_Click);
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.EnableAutoDragDrop = true;
            this.richTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.richTextBox5.Location = new System.Drawing.Point(451, 286);
            this.richTextBox5.Multiline = false;
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(375, 29);
            this.richTextBox5.TabIndex = 7;
            this.richTextBox5.Text = "Telefone";
            this.richTextBox5.Click += new System.EventHandler(this.RichTextBox5_Click);
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox6.EnableAutoDragDrop = true;
            this.richTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.richTextBox6.Location = new System.Drawing.Point(451, 362);
            this.richTextBox6.Multiline = false;
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(375, 30);
            this.richTextBox6.TabIndex = 8;
            this.richTextBox6.Text = "Senha";
            this.richTextBox6.Click += new System.EventHandler(this.RichTextBox6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.butCad);
            this.Controls.Add(this.usuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox usuario;
        private System.Windows.Forms.Button butCad;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox6;
    }
}

