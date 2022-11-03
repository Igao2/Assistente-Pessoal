namespace Helpy
{
    partial class Loginpopu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginpopu));
            this.senha = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.butLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // senha
            // 
            this.senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.senha.Location = new System.Drawing.Point(77, 343);
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(375, 24);
            this.senha.TabIndex = 10;
            this.senha.Text = "Senha";
            this.senha.Click += new System.EventHandler(this.senha_Click);
            this.senha.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.email.Location = new System.Drawing.Point(77, 221);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(375, 24);
            this.email.TabIndex = 9;
            this.email.Text = "Email";
            this.email.Click += new System.EventHandler(this.email_Click);
            // 
            // butLogin
            // 
            this.butLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butLogin.Location = new System.Drawing.Point(168, 464);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(155, 49);
            this.butLogin.TabIndex = 0;
            this.butLogin.UseVisualStyleBackColor = true;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // Loginpopu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 554);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.email);
            this.Controls.Add(this.senha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Loginpopu";
            this.Text = "Loginpopu";
            this.Load += new System.EventHandler(this.Loginpopu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button butLogin;
    }
}