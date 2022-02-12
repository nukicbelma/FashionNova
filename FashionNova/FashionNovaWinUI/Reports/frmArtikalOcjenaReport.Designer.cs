
namespace FashionNova.WinUI.Reports
{
    partial class frmArtikalOcjenaReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArtikalOcjenaReport));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OcjeneId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KlijentiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtikalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVrstaArtikla = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OcjeneId,
            this.KlijentiId,
            this.ArtikalId,
            this.Ocjena});
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(565, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // OcjeneId
            // 
            this.OcjeneId.DataPropertyName = "OcjeneId";
            this.OcjeneId.HeaderText = "OcjenaId";
            this.OcjeneId.Name = "OcjeneId";
            // 
            // KlijentiId
            // 
            this.KlijentiId.DataPropertyName = "KlijentiId";
            this.KlijentiId.HeaderText = "KlijentId";
            this.KlijentiId.Name = "KlijentiId";
            // 
            // ArtikalId
            // 
            this.ArtikalId.DataPropertyName = "ArtikliId";
            this.ArtikalId.HeaderText = "ArtikalId";
            this.ArtikalId.Name = "ArtikalId";
            // 
            // Ocjena
            // 
            this.Ocjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(12, 314);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(565, 23);
            this.btnPrintaj.TabIndex = 1;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Izvještaj na osnovu ocjena artikala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Odaberi artikal:";
// 
            // cmbVrstaArtikla
            // 
            this.cmbVrstaArtikla.FormattingEnabled = true;
            this.cmbVrstaArtikla.Location = new System.Drawing.Point(12, 61);
            this.cmbVrstaArtikla.Name = "cmbVrstaArtikla";
            this.cmbVrstaArtikla.Size = new System.Drawing.Size(191, 23);
            this.cmbVrstaArtikla.TabIndex = 14;
            this.cmbVrstaArtikla.SelectedIndexChanged += new System.EventHandler(this.cmbVrstaArtikla_SelectedIndexChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Trazi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmArtikalOcjenaReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(593, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbVrstaArtikla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmArtikalOcjenaReport";
            this.Text = "Izvjestaj";
            this.Load += new System.EventHandler(this.frmArtikalReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtDatumDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtDatumOd;
        private System.Windows.Forms.ComboBox cmbVrstaArtikla;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OcjeneId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlijentiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtikalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.Button button1;
    }
}