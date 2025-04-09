using System;

namespace BIBLIOTEKA_TESTOWANIE
{
    partial class AdminFormPanelGlowny
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFormPanelGlowny));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonZapomnieniUzytkownicy = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAktywniUzytkownicy = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDodajUzytkownika = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.buttonZapomnieniUzytkownicy);
            this.panel1.Controls.Add(this.buttonAktywniUzytkownicy);
            this.panel1.Controls.Add(this.buttonDodajUzytkownika);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-2, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 747);
            this.panel1.TabIndex = 46;
            // 
            // buttonZapomnieniUzytkownicy
            // 
            this.buttonZapomnieniUzytkownicy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonZapomnieniUzytkownicy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonZapomnieniUzytkownicy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonZapomnieniUzytkownicy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonZapomnieniUzytkownicy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.buttonZapomnieniUzytkownicy.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZapomnieniUzytkownicy.ForeColor = System.Drawing.Color.Black;
            this.buttonZapomnieniUzytkownicy.Location = new System.Drawing.Point(5, 365);
            this.buttonZapomnieniUzytkownicy.Name = "buttonZapomnieniUzytkownicy";
            this.buttonZapomnieniUzytkownicy.Size = new System.Drawing.Size(554, 60);
            this.buttonZapomnieniUzytkownicy.TabIndex = 51;
            this.buttonZapomnieniUzytkownicy.Text = "Zapomnieni użytkownicy";
            this.buttonZapomnieniUzytkownicy.Click += new System.EventHandler(this.buttonZapomnieniUzytkownicy_Click);
            // 
            // buttonAktywniUzytkownicy
            // 
            this.buttonAktywniUzytkownicy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAktywniUzytkownicy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAktywniUzytkownicy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAktywniUzytkownicy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAktywniUzytkownicy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.buttonAktywniUzytkownicy.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAktywniUzytkownicy.ForeColor = System.Drawing.Color.Black;
            this.buttonAktywniUzytkownicy.Location = new System.Drawing.Point(5, 299);
            this.buttonAktywniUzytkownicy.Name = "buttonAktywniUzytkownicy";
            this.buttonAktywniUzytkownicy.Size = new System.Drawing.Size(554, 60);
            this.buttonAktywniUzytkownicy.TabIndex = 50;
            this.buttonAktywniUzytkownicy.Text = "Aktywni użytkownicy";
            this.buttonAktywniUzytkownicy.Click += new System.EventHandler(this.buttonAktywniUzytkownicy_Click);
            // 
            // buttonDodajUzytkownika
            // 
            this.buttonDodajUzytkownika.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDodajUzytkownika.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonDodajUzytkownika.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonDodajUzytkownika.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonDodajUzytkownika.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(247)))));
            this.buttonDodajUzytkownika.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajUzytkownika.ForeColor = System.Drawing.Color.Black;
            this.buttonDodajUzytkownika.Location = new System.Drawing.Point(5, 233);
            this.buttonDodajUzytkownika.Name = "buttonDodajUzytkownika";
            this.buttonDodajUzytkownika.Size = new System.Drawing.Size(554, 60);
            this.buttonDodajUzytkownika.TabIndex = 49;
            this.buttonDodajUzytkownika.Text = "Dodaj użytkownika";
            this.buttonDodajUzytkownika.Click += new System.EventHandler(this.buttonDodajUzytkownika_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(559, 215);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(668, -186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1368, 1179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // AdminFormPanelGlowny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1479, 724);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminFormPanelGlowny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraSys | Panel administratora";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewUzytkownicy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button buttonDodajUzytkownika;
        private Guna.UI2.WinForms.Guna2Button buttonZapomnieniUzytkownicy;
        private Guna.UI2.WinForms.Guna2Button buttonAktywniUzytkownicy;
    }
}

