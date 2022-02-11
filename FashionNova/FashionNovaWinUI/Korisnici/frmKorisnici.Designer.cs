
namespace FashionNova.WinUI.Korisnici
{
    partial class frmKorisnici
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
            this.btnDodajKorisnika = new System.Windows.Forms.Button();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.Uloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajKorisnika
            // 
            this.btnDodajKorisnika.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDodajKorisnika.Location = new System.Drawing.Point(32, 81);
            this.btnDodajKorisnika.Name = "btnDodajKorisnika";
            this.btnDodajKorisnika.Size = new System.Drawing.Size(552, 23);
            this.btnDodajKorisnika.TabIndex = 9;
            this.btnDodajKorisnika.Text = "Dodaj novog korisnika";
            this.btnDodajKorisnika.UseVisualStyleBackColor = false;
            this.btnDodajKorisnika.Click += new System.EventHandler(this.btnDodajKorisnika_Click);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(504, 52);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(80, 23);
            this.btnPrikazi.TabIndex = 8;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime i prezime korisnika : ";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(32, 53);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(466, 23);
            this.txtPretraga.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKorisnici);
            this.groupBox1.Location = new System.Drawing.Point(32, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 258);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trenutni korisnici";
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Uloga,
            this.Ime,
            this.Prezime,
            this.KorisnickoIme,
            this.Email});
            this.dgvKorisnici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKorisnici.Location = new System.Drawing.Point(3, 19);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.RowTemplate.Height = 25;
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(552, 236);
            this.dgvKorisnici.TabIndex = 0;
            this.dgvKorisnici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisnici_CellContentClick);
            // 
            // Uloga
            // 
            this.Uloga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Uloga.DataPropertyName = "UlogeId";
            this.Uloga.HeaderText = "Uloga";
            this.Uloga.Name = "Uloga";
            this.Uloga.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "KorisnickoIme";
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // frmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(626, 402);
            this.Controls.Add(this.btnDodajKorisnika);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKorisnici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKorisnici";
            this.Load += new System.EventHandler(this.frmKorisnici_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajKorisnika;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uloga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}