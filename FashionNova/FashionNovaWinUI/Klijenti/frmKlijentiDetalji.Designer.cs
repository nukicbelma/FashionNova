
namespace FashionNova.WinUI.Klijenti
{
    partial class frmKlijentiDetalji
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
            this.tbcKorisniciPodaci = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImePrezime = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.txtnaslov = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbxSlika = new System.Windows.Forms.PictureBox();
            this.ofdSlika = new System.Windows.Forms.OpenFileDialog();
            this.txtSlika = new System.Windows.Forms.Label();
            this.tbcKorisniciPodaci.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcKorisniciPodaci
            // 
            this.tbcKorisniciPodaci.Controls.Add(this.tabPage1);
            this.tbcKorisniciPodaci.Controls.Add(this.tabPage2);
            this.tbcKorisniciPodaci.ItemSize = new System.Drawing.Size(200, 90);
            this.tbcKorisniciPodaci.Location = new System.Drawing.Point(-3, -3);
            this.tbcKorisniciPodaci.Name = "tbcKorisniciPodaci";
            this.tbcKorisniciPodaci.SelectedIndex = 0;
            this.tbcKorisniciPodaci.Size = new System.Drawing.Size(646, 325);
            this.tbcKorisniciPodaci.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.txtSlika);
            this.tabPage1.Controls.Add(this.pbxSlika);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtnaslov);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtTelefon);
            this.tabPage1.Controls.Add(this.txtKorisnickoIme);
            this.tabPage1.Controls.Add(this.txtImePrezime);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 94);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(638, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "O klijentu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime i prezime: ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 94);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(638, 227);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Narudzbe klijenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj telefona:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.AutoSize = true;
            this.txtImePrezime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtImePrezime.Location = new System.Drawing.Point(155, 73);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(51, 15);
            this.txtImePrezime.TabIndex = 4;
            this.txtImePrezime.Text = "korisnik";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.AutoSize = true;
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtKorisnickoIme.Location = new System.Drawing.Point(155, 110);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(51, 15);
            this.txtKorisnickoIme.TabIndex = 5;
            this.txtKorisnickoIme.Text = "korisnik";
            // 
            // txtTelefon
            // 
            this.txtTelefon.AutoSize = true;
            this.txtTelefon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTelefon.Location = new System.Drawing.Point(155, 147);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(51, 15);
            this.txtTelefon.TabIndex = 6;
            this.txtTelefon.Text = "korisnik";
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(155, 181);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(51, 15);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Text = "korisnik";
            // 
            // txtnaslov
            // 
            this.txtnaslov.AutoSize = true;
            this.txtnaslov.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtnaslov.Location = new System.Drawing.Point(266, 16);
            this.txtnaslov.Name = "txtnaslov";
            this.txtnaslov.Size = new System.Drawing.Size(72, 28);
            this.txtnaslov.TabIndex = 8;
            this.txtnaslov.Text = "klijent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fotografija: ";
            // 
            // pbxSlika
            // 
            this.pbxSlika.Location = new System.Drawing.Point(402, 64);
            this.pbxSlika.Name = "pbxSlika";
            this.pbxSlika.Size = new System.Drawing.Size(208, 132);
            this.pbxSlika.TabIndex = 10;
            this.pbxSlika.TabStop = false;
            this.pbxSlika.Click += new System.EventHandler(this.pbxSlika_Click);
            // 
            // ofdSlika
            // 
            this.ofdSlika.FileName = "openFileDialog1";
            // 
            // txtSlika
            // 
            this.txtSlika.AutoSize = true;
            this.txtSlika.Location = new System.Drawing.Point(312, 172);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(70, 15);
            this.txtSlika.TabIndex = 11;
            this.txtSlika.Text = "Fotografija: ";
            // 
            // frmKlijentiDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 319);
            this.Controls.Add(this.tbcKorisniciPodaci);
            this.Name = "frmKlijentiDetalji";
            this.Text = "Informacije o klijentu";
            this.Load += new System.EventHandler(this.frmKlijentiDetalji_Load);
            this.tbcKorisniciPodaci.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcKorisniciPodaci;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxSlika;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtnaslov;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label txtTelefon;
        private System.Windows.Forms.Label txtKorisnickoIme;
        private System.Windows.Forms.Label txtImePrezime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ofdSlika;
        private System.Windows.Forms.Label txtSlika;
    }
}