
namespace FashionNova.WinUI.Klijenti
{
    partial class frmKlijenti
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
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKlijenti = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(527, 48);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(80, 23);
            this.btnPrikazi.TabIndex = 13;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ime i prezime klijenta : ";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(55, 49);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(466, 23);
            this.txtPretraga.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKlijenti);
            this.groupBox1.Location = new System.Drawing.Point(55, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 267);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trenutni klijenti";
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.KorisnickoIme,
            this.Email});
            this.dgvKlijenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKlijenti.Location = new System.Drawing.Point(3, 19);
            this.dgvKlijenti.Name = "dgvKlijenti";
            this.dgvKlijenti.RowTemplate.Height = 25;
            this.dgvKlijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlijenti.Size = new System.Drawing.Size(552, 245);
            this.dgvKlijenti.TabIndex = 0;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "KorisnickoIme";
            this.KorisnickoIme.HeaderText = "KorisnickoIme";
            this.KorisnickoIme.Name = "KorisnickoIme";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // frmKlijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(672, 386);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKlijenti";
            this.Text = "Klijenti";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}