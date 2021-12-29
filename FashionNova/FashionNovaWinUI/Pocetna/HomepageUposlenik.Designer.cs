
namespace FashionNova.WinUI.Pocetna
{
    partial class HomepageUposlenik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageUposlenik));
            this.btnNarudzbe = new System.Windows.Forms.Button();
            this.btnKlijenti = new System.Windows.Forms.Button();
            this.btnIzvjestaji = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDatumiVrijeme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNarudzbe
            // 
            this.btnNarudzbe.BackColor = System.Drawing.SystemColors.Control;
            this.btnNarudzbe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNarudzbe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNarudzbe.Location = new System.Drawing.Point(76, 152);
            this.btnNarudzbe.Name = "btnNarudzbe";
            this.btnNarudzbe.Size = new System.Drawing.Size(171, 60);
            this.btnNarudzbe.TabIndex = 0;
            this.btnNarudzbe.Text = "Narudžbe";
            this.btnNarudzbe.UseVisualStyleBackColor = false;
            this.btnNarudzbe.Click += new System.EventHandler(this.btnNarudzbe_Click);
            // 
            // btnKlijenti
            // 
            this.btnKlijenti.BackColor = System.Drawing.SystemColors.Control;
            this.btnKlijenti.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKlijenti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKlijenti.Location = new System.Drawing.Point(253, 152);
            this.btnKlijenti.Name = "btnKlijenti";
            this.btnKlijenti.Size = new System.Drawing.Size(171, 60);
            this.btnKlijenti.TabIndex = 1;
            this.btnKlijenti.Text = "Klijenti";
            this.btnKlijenti.UseVisualStyleBackColor = false;
            this.btnKlijenti.Click += new System.EventHandler(this.btnKlijenti_Click);
            // 
            // btnIzvjestaji
            // 
            this.btnIzvjestaji.BackColor = System.Drawing.SystemColors.Control;
            this.btnIzvjestaji.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIzvjestaji.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnIzvjestaji.Location = new System.Drawing.Point(430, 152);
            this.btnIzvjestaji.Name = "btnIzvjestaji";
            this.btnIzvjestaji.Size = new System.Drawing.Size(171, 60);
            this.btnIzvjestaji.TabIndex = 2;
            this.btnIzvjestaji.Text = "Izvještaji";
            this.btnIzvjestaji.UseVisualStyleBackColor = false;
            this.btnIzvjestaji.Click += new System.EventHandler(this.btnIzvjestaji_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-2, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 19);
            this.label1.TabIndex = 25;
            this.label1.Text = "FASHIONNOVA ®";
            // 
            // lblDatumiVrijeme
            // 
            this.lblDatumiVrijeme.AutoSize = true;
            this.lblDatumiVrijeme.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblDatumiVrijeme.Location = new System.Drawing.Point(253, 295);
            this.lblDatumiVrijeme.Name = "lblDatumiVrijeme";
            this.lblDatumiVrijeme.Size = new System.Drawing.Size(146, 25);
            this.lblDatumiVrijeme.TabIndex = 26;
            this.lblDatumiVrijeme.Text = "/datumivrijeme/";
            // 
            // HomepageUposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(682, 346);
            this.Controls.Add(this.lblDatumiVrijeme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzvjestaji);
            this.Controls.Add(this.btnKlijenti);
            this.Controls.Add(this.btnNarudzbe);
            this.Name = "HomepageUposlenik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage::uposlenik";
            this.Load += new System.EventHandler(this.HomepageUposlenik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNarudzbe;
        private System.Windows.Forms.Button btnKlijenti;
        private System.Windows.Forms.Button btnIzvjestaji;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDatumiVrijeme;
    }
}