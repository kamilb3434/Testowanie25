namespace BIBLIOTEKA_TESTOWANIE
{
    partial class FormPodglad
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
            this.dataGridViewUzytkownicy = new System.Windows.Forms.DataGridView();
            this.buttonSzczegoly = new System.Windows.Forms.Button();
            this.buttonPowrot = new System.Windows.Forms.Button();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUzytkownicy)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUzytkownicy
            // 
            this.dataGridViewUzytkownicy.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewUzytkownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUzytkownicy.Location = new System.Drawing.Point(223, 73);
            this.dataGridViewUzytkownicy.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUzytkownicy.Name = "dataGridViewUzytkownicy";
            this.dataGridViewUzytkownicy.RowHeadersWidth = 51;
            this.dataGridViewUzytkownicy.RowTemplate.Height = 24;
            this.dataGridViewUzytkownicy.Size = new System.Drawing.Size(704, 366);
            this.dataGridViewUzytkownicy.TabIndex = 69;
            // 
            // buttonSzczegoly
            // 
            this.buttonSzczegoly.Location = new System.Drawing.Point(561, 15);
            this.buttonSzczegoly.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSzczegoly.Name = "buttonSzczegoly";
            this.buttonSzczegoly.Size = new System.Drawing.Size(151, 19);
            this.buttonSzczegoly.TabIndex = 72;
            this.buttonSzczegoly.Text = "Szczegółowe dane";
            this.buttonSzczegoly.UseVisualStyleBackColor = true;
            this.buttonSzczegoly.Click += new System.EventHandler(this.buttonSzczegoly_Click);
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Location = new System.Drawing.Point(561, 40);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(75, 23);
            this.buttonPowrot.TabIndex = 73;
            this.buttonPowrot.Text = "Powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(118, 12);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxImie.TabIndex = 74;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(118, 43);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazwisko.TabIndex = 75;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(118, 73);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "Login";
            // 
            // FormPodglad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.buttonPowrot);
            this.Controls.Add(this.buttonSzczegoly);
            this.Controls.Add(this.dataGridViewUzytkownicy);
            this.Name = "FormPodglad";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.FormPodglad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUzytkownicy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUzytkownicy;
        private System.Windows.Forms.Button buttonSzczegoly;
        private System.Windows.Forms.Button buttonPowrot;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}