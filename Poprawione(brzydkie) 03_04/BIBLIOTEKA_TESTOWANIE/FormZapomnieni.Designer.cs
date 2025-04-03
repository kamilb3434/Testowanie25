namespace BIBLIOTEKA_TESTOWANIE
{
    partial class FormZapomnieni
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
            this.buttonPowrot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_zapomniani)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ZnajdzZapomnianych
            // 
            this.button_ZnajdzZapomnianych.BackColor = System.Drawing.Color.Peru;
            this.button_ZnajdzZapomnianych.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_ZnajdzZapomnianych.Location = new System.Drawing.Point(205, 13);
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
            this.dataGridView_zapomniani.Location = new System.Drawing.Point(100, 114);
            this.dataGridView_zapomniani.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_zapomniani.Name = "dataGridView_zapomniani";
            this.dataGridView_zapomniani.RowHeadersWidth = 51;
            this.dataGridView_zapomniani.RowTemplate.Height = 24;
            this.dataGridView_zapomniani.Size = new System.Drawing.Size(574, 325);
            this.dataGridView_zapomniani.TabIndex = 40;
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Location = new System.Drawing.Point(528, 41);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(75, 23);
            this.buttonPowrot.TabIndex = 71;
            this.buttonPowrot.Text = "Powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // FormZapomnieni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1243, 450);
            this.Controls.Add(this.buttonPowrot);
            this.Controls.Add(this.dataGridView_zapomniani);
            this.Controls.Add(this.button_ZnajdzZapomnianych);
            this.Name = "FormZapomnieni";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_zapomniani)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ZnajdzZapomnianych;
        private System.Windows.Forms.DataGridView dataGridView_zapomniani;
        private System.Windows.Forms.Button buttonPowrot;
    }
}