
namespace FashionNova.WinUI.MaterijalBojaVelicinaVrsta
{
    partial class frmDodajBoju
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvVrste = new System.Windows.Forms.DataGridView();
            this.BojaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrste)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvVrste);
            this.groupBox1.Location = new System.Drawing.Point(3, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 118);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista boja";
            // 
            // dgvVrste
            // 
            this.dgvVrste.AllowUserToAddRows = false;
            this.dgvVrste.AllowUserToDeleteRows = false;
            this.dgvVrste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVrste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BojaId,
            this.Naziv});
            this.dgvVrste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVrste.Location = new System.Drawing.Point(3, 19);
            this.dgvVrste.Name = "dgvVrste";
            this.dgvVrste.ReadOnly = true;
            this.dgvVrste.RowTemplate.Height = 25;
            this.dgvVrste.Size = new System.Drawing.Size(375, 96);
            this.dgvVrste.TabIndex = 0;
            // 
            // BojaId
            // 
            this.BojaId.DataPropertyName = "BojaId";
            this.BojaId.HeaderText = "Id";
            this.BojaId.Name = "BojaId";
            this.BojaId.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(299, 32);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 7;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(12, 32);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(280, 23);
            this.txtNaziv.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dodaj novu boju:";
            // 
            // frmDodajBoju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(391, 192);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Name = "frmDodajBoju";
            this.Text = "Boje";
            this.Load += new System.EventHandler(this.frmDodajBoju_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVrste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVrste;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BojaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
    }
}