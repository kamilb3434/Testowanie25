namespace BIBLIOTEKA_TESTOWANIE
{
    partial class AdminFormZapomnieniUzytkownicy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFormZapomnieniUzytkownicy));
            this.dataGridView_zapomniani = new System.Windows.Forms.DataGridView();
            this.buttonPowrot = new System.Windows.Forms.Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_zapomniani)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_zapomniani
            // 
            this.dataGridView_zapomniani.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView_zapomniani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_zapomniani.Location = new System.Drawing.Point(133, 140);
            this.dataGridView_zapomniani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_zapomniani.Name = "dataGridView_zapomniani";
            this.dataGridView_zapomniani.RowHeadersWidth = 51;
            this.dataGridView_zapomniani.RowTemplate.Height = 24;
            this.dataGridView_zapomniani.Size = new System.Drawing.Size(765, 400);
            this.dataGridView_zapomniani.TabIndex = 40;
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Location = new System.Drawing.Point(424, 47);
            this.buttonPowrot.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(100, 28);
            this.buttonPowrot.TabIndex = 71;
            this.buttonPowrot.Text = "Powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // AdminFormZapomnieniUzytkownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1657, 554);
            this.Controls.Add(this.buttonPowrot);
            this.Controls.Add(this.dataGridView_zapomniani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminFormZapomnieniUzytkownicy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraSys | Zapomnieni użytkownicy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormZapomnieni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_zapomniani)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_zapomniani;
        private System.Windows.Forms.Button buttonPowrot;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}