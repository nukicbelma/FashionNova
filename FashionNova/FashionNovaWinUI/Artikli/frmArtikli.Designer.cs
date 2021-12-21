
namespace FashionNovaWinUI.Artikli
{
    partial class frmArtikli
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
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaArtiklaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VelicinaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterijalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BojaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.cmbVelicina = new System.Windows.Forms.ComboBox();
            this.cmbBoja = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDodajArtikal = new System.Windows.Forms.Button();
            this.cmbVrstaArtikla = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Sifra,
            this.VrstaArtiklaId,
            this.VelicinaId,
            this.MaterijalId,
            this.BojaId,
            this.Cijena});
            this.dgvArtikli.Location = new System.Drawing.Point(12, 86);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.RowTemplate.Height = 25;
            this.dgvArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtikli.Size = new System.Drawing.Size(720, 223);
            this.dgvArtikli.TabIndex = 0;
            this.dgvArtikli.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArtikli_CellContentClick);
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Sifra
            // 
            this.Sifra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Sifra";
            this.Sifra.Name = "Sifra";
            // 
            // VrstaArtiklaId
            // 
            this.VrstaArtiklaId.DataPropertyName = "VrstaArtiklaId";
            this.VrstaArtiklaId.HeaderText = "VrstaArtiklaId";
            this.VrstaArtiklaId.Name = "VrstaArtiklaId";
            // 
            // VelicinaId
            // 
            this.VelicinaId.DataPropertyName = "VelicinaId";
            this.VelicinaId.HeaderText = "VelicinaId";
            this.VelicinaId.Name = "VelicinaId";
            // 
            // MaterijalId
            // 
            this.MaterijalId.DataPropertyName = "MaterijalId";
            this.MaterijalId.HeaderText = "MaterijalId";
            this.MaterijalId.Name = "MaterijalId";
            // 
            // BojaId
            // 
            this.BojaId.DataPropertyName = "BojaId";
            this.BojaId.HeaderText = "BojaId";
            this.BojaId.Name = "BojaId";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(13, 47);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(366, 23);
            this.txtNaziv.TabIndex = 1;
            this.txtNaziv.TextChanged += new System.EventHandler(this.txtNaziv_TextChanged);
            // 
            // cmbVelicina
            // 
            this.cmbVelicina.FormattingEnabled = true;
            this.cmbVelicina.Location = new System.Drawing.Point(503, 46);
            this.cmbVelicina.Name = "cmbVelicina";
            this.cmbVelicina.Size = new System.Drawing.Size(112, 23);
            this.cmbVelicina.TabIndex = 3;
            this.cmbVelicina.SelectedIndexChanged += new System.EventHandler(this.cmbVelicina_SelectedIndexChanged);
            // 
            // cmbBoja
            // 
            this.cmbBoja.FormattingEnabled = true;
            this.cmbBoja.Location = new System.Drawing.Point(621, 47);
            this.cmbBoja.Name = "cmbBoja";
            this.cmbBoja.Size = new System.Drawing.Size(112, 23);
            this.cmbBoja.TabIndex = 4;
            this.cmbBoja.SelectedIndexChanged += new System.EventHandler(this.cmbBoja_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kategorija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Boja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Velicina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(739, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 10;
            // 
            // btnDodajArtikal
            // 
            this.btnDodajArtikal.Location = new System.Drawing.Point(587, 315);
            this.btnDodajArtikal.Name = "btnDodajArtikal";
            this.btnDodajArtikal.Size = new System.Drawing.Size(145, 26);
            this.btnDodajArtikal.TabIndex = 12;
            this.btnDodajArtikal.Text = "Novi artikal";
            this.btnDodajArtikal.UseVisualStyleBackColor = true;
            this.btnDodajArtikal.Click += new System.EventHandler(this.btnDodajArtikal_Click);
            // 
            // cmbVrstaArtikla
            // 
            this.cmbVrstaArtikla.FormattingEnabled = true;
            this.cmbVrstaArtikla.Location = new System.Drawing.Point(385, 46);
            this.cmbVrstaArtikla.Name = "cmbVrstaArtikla";
            this.cmbVrstaArtikla.Size = new System.Drawing.Size(112, 23);
            this.cmbVrstaArtikla.TabIndex = 13;
            this.cmbVrstaArtikla.SelectedIndexChanged += new System.EventHandler(this.cmbVrstaArtikla_SelectedIndexChanged);
            // 
            // frmArtikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(752, 346);
            this.Controls.Add(this.cmbVrstaArtikla);
            this.Controls.Add(this.btnDodajArtikal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoja);
            this.Controls.Add(this.cmbVelicina);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.dgvArtikli);
            this.Name = "frmArtikli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artikli";
            this.Load += new System.EventHandler(this.frmArtikli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ComboBox cmbVelicina;
        private System.Windows.Forms.ComboBox cmbBoja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDodajArtikal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaArtiklaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VelicinaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterijalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BojaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.ComboBox cmbVrstaArtikla;
    }
}