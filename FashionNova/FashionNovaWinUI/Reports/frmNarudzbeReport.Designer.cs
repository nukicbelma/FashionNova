
namespace FashionNova.WinUI.Reports
{
    partial class frmNarudzbeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNarudzbeReport));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.NarudzbaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznosBezPDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IznosSaPDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KlijentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDatumOd = new System.Windows.Forms.DateTimePicker();
            this.txtBrojNarudzbe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatumDo = new System.Windows.Forms.DateTimePicker();
            this.btnPrintaj = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NarudzbaId,
            this.BrojNarudzbe,
            this.DatumNarudzbe,
            this.IznosBezPDV,
            this.IznosSaPDV,
            this.KlijentId});
            this.dgv.Location = new System.Drawing.Point(35, 79);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 25;
            this.dgv.Size = new System.Drawing.Size(677, 186);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NarudzbaId
            // 
            this.NarudzbaId.DataPropertyName = "NarudzbaId";
            this.NarudzbaId.HeaderText = "Id";
            this.NarudzbaId.Name = "NarudzbaId";
            this.NarudzbaId.Width = 50;
            // 
            // BrojNarudzbe
            // 
            this.BrojNarudzbe.DataPropertyName = "BrojNarudzbe";
            this.BrojNarudzbe.HeaderText = "Br.Narudzbe";
            this.BrojNarudzbe.Name = "BrojNarudzbe";
            this.BrojNarudzbe.Width = 134;
            // 
            // DatumNarudzbe
            // 
            this.DatumNarudzbe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumNarudzbe.DataPropertyName = "DatumNarudzbe";
            this.DatumNarudzbe.HeaderText = "Datum i vrijeme narudzbe";
            this.DatumNarudzbe.Name = "DatumNarudzbe";
            // 
            // IznosBezPDV
            // 
            this.IznosBezPDV.DataPropertyName = "IznosBezPDV";
            this.IznosBezPDV.HeaderText = "Iznos bez PDV";
            this.IznosBezPDV.Name = "IznosBezPDV";
            // 
            // IznosSaPDV
            // 
            this.IznosSaPDV.DataPropertyName = "IznosSaPDV";
            this.IznosSaPDV.HeaderText = "Iznos sa PDV";
            this.IznosSaPDV.Name = "IznosSaPDV";
            // 
            // KlijentId
            // 
            this.KlijentId.DataPropertyName = "KlijentId";
            this.KlijentId.HeaderText = "KlijentId";
            this.KlijentId.Name = "KlijentId";
            // 
            // txtDatumOd
            // 
            this.txtDatumOd.Location = new System.Drawing.Point(306, 39);
            this.txtDatumOd.Name = "txtDatumOd";
            this.txtDatumOd.Size = new System.Drawing.Size(160, 23);
            this.txtDatumOd.TabIndex = 1;
            this.txtDatumOd.ValueChanged += new System.EventHandler(this.txtDatumOd_ValueChanged);
            // 
            // txtBrojNarudzbe
            // 
            this.txtBrojNarudzbe.Location = new System.Drawing.Point(127, 39);
            this.txtBrojNarudzbe.Name = "txtBrojNarudzbe";
            this.txtBrojNarudzbe.Size = new System.Drawing.Size(107, 23);
            this.txtBrojNarudzbe.TabIndex = 3;
            this.txtBrojNarudzbe.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Broj narudzbe: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum od: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum do: ";
            // 
            // txtDatumDo
            // 
            this.txtDatumDo.Location = new System.Drawing.Point(544, 39);
            this.txtDatumDo.Name = "txtDatumDo";
            this.txtDatumDo.Size = new System.Drawing.Size(160, 23);
            this.txtDatumDo.TabIndex = 7;
            this.txtDatumDo.ValueChanged += new System.EventHandler(this.txtDatumDo_ValueChanged);
            // 
            // btnPrintaj
            // 
            this.btnPrintaj.Location = new System.Drawing.Point(35, 271);
            this.btnPrintaj.Name = "btnPrintaj";
            this.btnPrintaj.Size = new System.Drawing.Size(677, 23);
            this.btnPrintaj.TabIndex = 8;
            this.btnPrintaj.Text = "Printaj";
            this.btnPrintaj.UseVisualStyleBackColor = true;
            this.btnPrintaj.Click += new System.EventHandler(this.btnPrintaj_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(223, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Report/Izvjestaj na osnovu narudžbi";
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
            // frmNarudzbeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(751, 306);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPrintaj);
            this.Controls.Add(this.txtDatumDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrojNarudzbe);
            this.Controls.Add(this.txtDatumOd);
            this.Controls.Add(this.dgv);
            this.Name = "frmNarudzbeReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izvjestaji";
            this.Load += new System.EventHandler(this.frmKreirajReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DateTimePicker txtDatumOd;
        private System.Windows.Forms.TextBox txtBrojNarudzbe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtDatumDo;
        private System.Windows.Forms.Button btnPrintaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NarudzbaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosBezPDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IznosSaPDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn KlijentId;
    }
}