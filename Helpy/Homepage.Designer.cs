﻿namespace Helpy
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.Compromissos = new System.Windows.Forms.Button();
            this.Tarefas = new System.Windows.Forms.Button();
            this.formLoader = new System.Windows.Forms.Panel();
            this.butlogoff = new System.Windows.Forms.Button();
            this.butHome = new System.Windows.Forms.Button();
            this.Amigos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Compromissos
            // 
            this.Compromissos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.Compromissos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Compromissos.BackgroundImage")));
            this.Compromissos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Compromissos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.Compromissos.FlatAppearance.BorderSize = 0;
            this.Compromissos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Compromissos.Location = new System.Drawing.Point(-2, 198);
            this.Compromissos.Name = "Compromissos";
            this.Compromissos.Size = new System.Drawing.Size(64, 64);
            this.Compromissos.TabIndex = 9;
            this.Compromissos.UseVisualStyleBackColor = false;
            this.Compromissos.Click += new System.EventHandler(this.Compromissos_Click_1);
            this.Compromissos.MouseEnter += new System.EventHandler(this.Button2_MouseEnter);
            this.Compromissos.MouseLeave += new System.EventHandler(this.Button2_MouseLeave);
            // 
            // Tarefas
            // 
            this.Tarefas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.Tarefas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tarefas.BackgroundImage")));
            this.Tarefas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tarefas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.Tarefas.FlatAppearance.BorderSize = 0;
            this.Tarefas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tarefas.Location = new System.Drawing.Point(-2, 128);
            this.Tarefas.Name = "Tarefas";
            this.Tarefas.Size = new System.Drawing.Size(64, 64);
            this.Tarefas.TabIndex = 12;
            this.Tarefas.UseVisualStyleBackColor = false;
            this.Tarefas.Click += new System.EventHandler(this.Compromissos_Click);
            this.Tarefas.MouseEnter += new System.EventHandler(this.Compromissos_MouseEnter);
            this.Tarefas.MouseLeave += new System.EventHandler(this.Compromissos_MouseLeave);
            // 
            // formLoader
            // 
            this.formLoader.Location = new System.Drawing.Point(68, 62);
            this.formLoader.Name = "formLoader";
            this.formLoader.Size = new System.Drawing.Size(856, 479);
            this.formLoader.TabIndex = 13;
            // 
            // butlogoff
            // 
            this.butlogoff.Location = new System.Drawing.Point(859, 2);
            this.butlogoff.Name = "butlogoff";
            this.butlogoff.Size = new System.Drawing.Size(75, 54);
            this.butlogoff.TabIndex = 14;
            this.butlogoff.UseVisualStyleBackColor = true;
            this.butlogoff.Click += new System.EventHandler(this.butlogoff_Click);
            // 
            // butHome
            // 
            this.butHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butHome.Location = new System.Drawing.Point(-2, 2);
            this.butHome.Name = "butHome";
            this.butHome.Size = new System.Drawing.Size(96, 54);
            this.butHome.TabIndex = 0;
            this.butHome.UseVisualStyleBackColor = true;
            this.butHome.Click += new System.EventHandler(this.butHome_Click);
            // 
            // Amigos
            // 
            this.Amigos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.Amigos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Amigos.BackgroundImage")));
            this.Amigos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Amigos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.Amigos.FlatAppearance.BorderSize = 0;
            this.Amigos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Amigos.Location = new System.Drawing.Point(-2, 268);
            this.Amigos.Name = "Amigos";
            this.Amigos.Size = new System.Drawing.Size(64, 64);
            this.Amigos.TabIndex = 15;
            this.Amigos.UseVisualStyleBackColor = false;
            this.Amigos.Click += new System.EventHandler(this.Amigos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 63);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Amigos);
            this.Controls.Add(this.butHome);
            this.Controls.Add(this.butlogoff);
            this.Controls.Add(this.formLoader);
            this.Controls.Add(this.Tarefas);
            this.Controls.Add(this.Compromissos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Homepage_FormClosing);
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Compromissos;
        private System.Windows.Forms.Button Tarefas;
        private System.Windows.Forms.Panel formLoader;
        private System.Windows.Forms.Button butlogoff;
        private System.Windows.Forms.Button butHome;
        private System.Windows.Forms.Button Amigos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}