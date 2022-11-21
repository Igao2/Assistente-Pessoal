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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginpopu));
            this.senha = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // senha
            // 
            this.senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.senha.Location = new System.Drawing.Point(86, 309);
            this.senha.Name = "senha";
            this.senha.PasswordChar = '*';
            this.senha.Size = new System.Drawing.Size(375, 25);
            this.senha.TabIndex = 10;
            this.senha.Text = "Senha";
            this.senha.Click += new System.EventHandler(this.senha_Click);
            this.senha.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.email.Location = new System.Drawing.Point(86, 198);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(375, 25);
            this.email.TabIndex = 9;
            this.email.Text = "Email";
            this.email.Click += new System.EventHandler(this.email_Click);
            this.email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // buttonlogin
            // 
            this.buttonlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonlogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.buttonlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonlogin.Location = new System.Drawing.Point(172, 422);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(145, 36);
            this.buttonlogin.TabIndex = 8;
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.Buttonlogin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Webdings", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(439, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 47);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Visible = true;
            // 
            // Loginpopu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.email);
            this.Controls.Add(this.senha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Loginpopu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Loginpopu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox senha;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}