namespace BIBLIOTEKA_TESTOWANIE
{
    partial class Form4
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
            this.button_ZnajdzZapomnianych = new System.Windows.Forms.Button();
            this.dataGridView_zapomniani = new System.Windows.Forms.DataGridView();
            this.button_zapomnij = new System.Windows.Forms.Button();
            this.dataGridViewUzytkownicy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_zapomniani)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUzytkownicy)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ZnajdzZapomnianych
            // 
            this.button_ZnajdzZapomnianych.BackColor = System.Drawing.Color.Peru;
            this.button_ZnajdzZapomnianych.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_ZnajdzZapomnianych.Location = new System.Drawing.Point(863, 11);
            this.button_ZnajdzZapomnianych.Margin = new System.Windows.Forms.Padding(2);
            this.button_ZnajdzZapomnianych.Name = "button_ZnajdzZapomnianych";
            this.button_ZnajdzZapomnianych.Size = new System.Drawing.Size(209, 79);
            this.button_ZnajdzZapomnianych.TabIndex = 39;
            this.button_ZnajdzZapomnianych.Text = "Znajdź zapomnianych";
            this.button_ZnajdzZapomnianych.UseVisualStyleBackColor = false;
            this.button_ZnajdzZapomnianych.Click += new System.EventHandler(this.button_ZnajdzZapomnianych_Click_1);
            // 
            // dataGridView_zapomniani
            // 
            this.dataGridView_zapomniani.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_zapomniani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_zapomniani.Location = new System.Drawing.Point(658, 114);
            this.dataGridView_zapomniani.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_zapomniani.Name = "dataGridView_zapomniani";
            this.dataGridView_zapomniani.RowHeadersWidth = 51;
            this.dataGridView_zapomniani.RowTemplate.Height = 24;
            this.dataGridView_zapomniani.Size = new System.Drawing.Size(574, 325);
            this.dataGridView_zapomniani.TabIndex = 40;
            // 
            // button_zapomnij
            // 
            this.button_zapomnij.BackColor = System.Drawing.Color.Peru;
            this.button_zapomnij.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zapomnij.Location = new System.Drawing.Point(168, 11);
            this.button_zapomnij.Margin = new System.Windows.Forms.Padding(2);
            this.button_zapomnij.Name = "button_zapomnij";
            this.button_zapomnij.Size = new System.Drawing.Size(209, 79);
            this.button_zapomnij.TabIndex = 41;
            this.button_zapomnij.Text = "Zapomnij użytkownika";
            this.button_zapomnij.UseVisualStyleBackColor = false;
            this.button_zapomnij.Click += new System.EventHandler(this.button_zapomnij_Click);
            // 
            // dataGridViewUzytkownicy
            // 
            this.dataGridViewUzytkownicy.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewUzytkownicy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUzytkownicy.Location = new System.Drawing.Point(11, 114);
            this.dataGridViewUzytkownicy.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewUzytkownicy.Name = "dataGridViewUzytkownicy";
            this.dataGridViewUzytkownicy.RowHeadersWidth = 51;
            this.dataGridViewUzytkownicy.RowTemplate.Height = 24;
            this.dataGridViewUzytkownicy.Size = new System.Drawing.Size(584, 325);
            this.dataGridViewUzytkownicy.TabIndex = 70;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1243, 450);
            this.Controls.Add(this.dataGridViewUzytkownicy);
            this.Controls.Add(this.button_zapomnij);
            this.Controls.Add(this.dataGridView_zapomniani);
            this.Controls.Add(this.button_ZnajdzZapomnianych);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_zapomniani)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUzytkownicy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ZnajdzZapomnianych;
        private System.Windows.Forms.DataGridView dataGridView_zapomniani;
        private System.Windows.Forms.Button button_zapomnij;
        private System.Windows.Forms.DataGridView dataGridViewUzytkownicy;
    }
}