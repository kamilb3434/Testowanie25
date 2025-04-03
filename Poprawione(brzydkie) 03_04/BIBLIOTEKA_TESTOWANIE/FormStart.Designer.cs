using System;

namespace BIBLIOTEKA_TESTOWANIE
{
    partial class FormStart
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
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPodglad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonZapomnieni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.BackColor = System.Drawing.Color.Peru;
            this.buttonDodaj.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodaj.Location = new System.Drawing.Point(65, 185);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(209, 79);
            this.buttonDodaj.TabIndex = 39;
            this.buttonDodaj.Text = "Dodaj użytkownika";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(526, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 41;
            this.label1.Text = "Biblioteka";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonPodglad
            // 
            this.buttonPodglad.BackColor = System.Drawing.Color.Peru;
            this.buttonPodglad.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPodglad.Location = new System.Drawing.Point(501, 185);
            this.buttonPodglad.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPodglad.Name = "buttonPodglad";
            this.buttonPodglad.Size = new System.Drawing.Size(209, 79);
            this.buttonPodglad.TabIndex = 42;
            this.buttonPodglad.Text = "Wyszukaj użytkowników";
            this.buttonPodglad.UseVisualStyleBackColor = false;
            this.buttonPodglad.Click += new System.EventHandler(this.buttonPodglad_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BIBLIOTEKA_TESTOWANIE.Properties.Resources.ksiazki4;
            this.pictureBox1.Image = global::BIBLIOTEKA_TESTOWANIE.Properties.Resources.ksiazki4;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1230, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // buttonZapomnieni
            // 
            this.buttonZapomnieni.BackColor = System.Drawing.Color.Peru;
            this.buttonZapomnieni.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZapomnieni.Location = new System.Drawing.Point(926, 185);
            this.buttonZapomnieni.Margin = new System.Windows.Forms.Padding(0);
            this.buttonZapomnieni.Name = "buttonZapomnieni";
            this.buttonZapomnieni.Size = new System.Drawing.Size(209, 79);
            this.buttonZapomnieni.TabIndex = 43;
            this.buttonZapomnieni.Text = "Zapomnij użytkownika";
            this.buttonZapomnieni.UseVisualStyleBackColor = false;
            this.buttonZapomnieni.Click += new System.EventHandler(this.buttonZapomnieni_Click_1);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1229, 450);
            this.Controls.Add(this.buttonZapomnieni);
            this.Controls.Add(this.buttonPodglad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDodaj);
            this.Name = "FormStart";
            this.Text = "Start";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        #endregion
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.DataGridView dataGridViewUzytkownicy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPodglad;
        private System.Windows.Forms.Button buttonZapomnieni;
    }
}

