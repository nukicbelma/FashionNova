
namespace FashionNova.WinUI.Reports
{
    partial class frmIndexReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNarudzbe = new System.Windows.Forms.Button();
            this.btnArtikli = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Želite uvid podataka na osnovu->";
            // 
            // btnNarudzbe
            // 
            this.btnNarudzbe.Location = new System.Drawing.Point(45, 90);
            this.btnNarudzbe.Name = "btnNarudzbe";
            this.btnNarudzbe.Size = new System.Drawing.Size(233, 55);
            this.btnNarudzbe.TabIndex = 1;
            this.btnNarudzbe.Text = "Narudzbi";
            this.btnNarudzbe.UseVisualStyleBackColor = true;
            this.btnNarudzbe.Click += new System.EventHandler(this.btnNarudzbe_Click);
            // 
            // btnArtikli
            // 
            this.btnArtikli.Location = new System.Drawing.Point(45, 151);
            this.btnArtikli.Name = "btnArtikli";
            this.btnArtikli.Size = new System.Drawing.Size(233, 55);
            this.btnArtikli.TabIndex = 2;
            this.btnArtikli.Text = "Ocjena";
            this.btnArtikli.UseVisualStyleBackColor = true;
            this.btnArtikli.Click += new System.EventHandler(this.btnArtikli_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pojedinačnih artikala";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmIndexReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(326, 313);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnArtikli);
            this.Controls.Add(this.btnNarudzbe);
            this.Controls.Add(this.label1);
            this.Name = "frmIndexReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNarudzbe;
        private System.Windows.Forms.Button btnArtikli;
        private System.Windows.Forms.Button button1;
    }
}