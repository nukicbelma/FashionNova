
namespace FashionNova.WinUI.Artikli
{
    partial class frmDodajUrediArtikal
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
            this.cmbVrstaArtikla = new System.Windows.Forms.ComboBox();
            this.cmbMaterijal = new System.Windows.Forms.ComboBox();
            this.materijal = new System.Windows.Forms.Label();
            this.cmbBoja = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbVelicina = new System.Windows.Forms.ComboBox();
            this.btnUcitajSliku = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSlika = new System.Windows.Forms.TextBox();
            this.pbxSlika = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.ofdSlika = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVrstaArtikla
            // 
            this.cmbVrstaArtikla.FormattingEnabled = true;
            this.cmbVrstaArtikla.Location = new System.Drawing.Point(85, 39);
            this.cmbVrstaArtikla.Name = "cmbVrstaArtikla";
            this.cmbVrstaArtikla.Size = new System.Drawing.Size(201, 23);
            this.cmbVrstaArtikla.TabIndex = 52;
            // 
            // cmbMaterijal
            // 
            this.cmbMaterijal.FormattingEnabled = true;
            this.cmbMaterijal.Location = new System.Drawing.Point(85, 143);
            this.cmbMaterijal.Name = "cmbMaterijal";
            this.cmbMaterijal.Size = new System.Drawing.Size(201, 23);
            this.cmbMaterijal.TabIndex = 51;
            // 
            // materijal
            // 
            this.materijal.AutoSize = true;
            this.materijal.Location = new System.Drawing.Point(23, 146);
            this.materijal.Name = "materijal";
            this.materijal.Size = new System.Drawing.Size(59, 15);
            this.materijal.TabIndex = 50;
            this.materijal.Text = "Materijal: ";
            // 
            // cmbBoja
            // 
            this.cmbBoja.FormattingEnabled = true;
            this.cmbBoja.Location = new System.Drawing.Point(197, 117);
            this.cmbBoja.Name = "cmbBoja";
            this.cmbBoja.Size = new System.Drawing.Size(89, 23);
            this.cmbBoja.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 48;
            this.label7.Text = "Boja: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 47;
            this.label5.Text = "Velicina:";
            // 
            // cmbVelicina
            // 
            this.cmbVelicina.FormattingEnabled = true;
            this.cmbVelicina.Location = new System.Drawing.Point(85, 117);
            this.cmbVelicina.Name = "cmbVelicina";
            this.cmbVelicina.Size = new System.Drawing.Size(73, 23);
            this.cmbVelicina.TabIndex = 46;
            // 
            // btnUcitajSliku
            // 
            this.btnUcitajSliku.Location = new System.Drawing.Point(250, 198);
            this.btnUcitajSliku.Name = "btnUcitajSliku";
            this.btnUcitajSliku.Size = new System.Drawing.Size(36, 23);
            this.btnUcitajSliku.TabIndex = 45;
            this.btnUcitajSliku.Text = "...";
            this.btnUcitajSliku.UseVisualStyleBackColor = true;
            this.btnUcitajSliku.Click += new System.EventHandler(this.btnUcitajSliku_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "Slika:";
            // 
            // txtSlika
            // 
            this.txtSlika.Location = new System.Drawing.Point(85, 198);
            this.txtSlika.Name = "txtSlika";
            this.txtSlika.Size = new System.Drawing.Size(161, 23);
            this.txtSlika.TabIndex = 43;
            // 
            // pbxSlika
            // 
            this.pbxSlika.Location = new System.Drawing.Point(305, 39);
            this.pbxSlika.Name = "pbxSlika";
            this.pbxSlika.Size = new System.Drawing.Size(222, 184);
            this.pbxSlika.TabIndex = 42;
            this.pbxSlika.TabStop = false;
            this.pbxSlika.Click += new System.EventHandler(this.pbxSlika_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Cijena:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(85, 169);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(201, 23);
            this.txtCijena.TabIndex = 40;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(85, 88);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(201, 23);
            this.txtNaziv.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "Naziv:";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(85, 64);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(201, 23);
            this.txtSifra.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 36;
            this.label2.Text = "Sifra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Vrsta artikla:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(423, 240);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(104, 23);
            this.btnSacuvaj.TabIndex = 53;
            this.btnSacuvaj.Text = "Spasi";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // ofdSlika
            // 
            this.ofdSlika.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDodajUrediArtikal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(544, 275);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cmbVrstaArtikla);
            this.Controls.Add(this.cmbMaterijal);
            this.Controls.Add(this.materijal);
            this.Controls.Add(this.cmbBoja);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbVelicina);
            this.Controls.Add(this.btnUcitajSliku);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSlika);
            this.Controls.Add(this.pbxSlika);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDodajUrediArtikal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj/Uredi";
            this.Load += new System.EventHandler(this.frmDodajUrediArtikal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbVrstaArtikla;
        private System.Windows.Forms.ComboBox cmbMaterijal;
        private System.Windows.Forms.Label materijal;
        private System.Windows.Forms.ComboBox cmbBoja;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbVelicina;
        private System.Windows.Forms.Button btnUcitajSliku;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSlika;
        private System.Windows.Forms.PictureBox pbxSlika;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.OpenFileDialog ofdSlika;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}