namespace DodanieUzytkownika
{
    partial class Form1
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
            txtLogin = new TextBox();
            txtImie = new TextBox();
            txtNazwisko = new TextBox();
            txtPesel = new TextBox();
            txtEmail = new TextBox();
            txtTelefon = new TextBox();
            cmbPlec = new ComboBox();
            btnDodaj = new Button();
            dgvUsers = new DataGridView();
            lblError = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(112, 59);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(119, 23);
            txtLogin.TabIndex = 0;
            txtLogin.TextChanged += textBox1_TextChanged;
            // 
            // txtImie
            // 
            txtImie.Location = new Point(114, 113);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(117, 23);
            txtImie.TabIndex = 1;
            // 
            // txtNazwisko
            // 
            txtNazwisko.Location = new Point(112, 172);
            txtNazwisko.Name = "txtNazwisko";
            txtNazwisko.Size = new Size(119, 23);
            txtNazwisko.TabIndex = 2;
            // 
            // txtPesel
            // 
            txtPesel.Location = new Point(110, 275);
            txtPesel.Name = "txtPesel";
            txtPesel.Size = new Size(121, 23);
            txtPesel.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(110, 338);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(121, 23);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(110, 394);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(121, 23);
            txtTelefon.TabIndex = 5;
            // 
            // cmbPlec
            // 
            cmbPlec.FormattingEnabled = true;
            cmbPlec.Location = new Point(110, 224);
            cmbPlec.Name = "cmbPlec";
            cmbPlec.Size = new Size(121, 23);
            cmbPlec.TabIndex = 6;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(112, 454);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(119, 23);
            btnDodaj.TabIndex = 7;
            btnDodaj.Text = "Dodaj osobę";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(274, 45);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowTemplate.Height = 25;
            dgvUsers.Size = new Size(458, 458);
            dgvUsers.TabIndex = 8;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(168, 488);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 9;
            lblError.Click += lblError_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 62);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 10;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 116);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 11;
            label2.Text = "Imię";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 175);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 12;
            label3.Text = "Nazwisko";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 229);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 13;
            label4.Text = "Płeć";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 275);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 14;
            label5.Text = "PESEL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 341);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 15;
            label6.Text = "Adres e-mail";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 402);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 16;
            label7.Text = "Numer Telefonu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 538);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblError);
            Controls.Add(dgvUsers);
            Controls.Add(btnDodaj);
            Controls.Add(cmbPlec);
            Controls.Add(txtTelefon);
            Controls.Add(txtEmail);
            Controls.Add(txtPesel);
            Controls.Add(txtNazwisko);
            Controls.Add(txtImie);
            Controls.Add(txtLogin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private TextBox txtImie;
        private TextBox txtNazwisko;
        private TextBox txtPesel;
        private TextBox txtEmail;
        private TextBox txtTelefon;
        private ComboBox cmbPlec;
        private Button btnDodaj;
        private DataGridView dgvUsers;
        private Label lblError;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}