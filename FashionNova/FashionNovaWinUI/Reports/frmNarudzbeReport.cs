using FashionNova.Model.Requests;
using FashionNovaWinUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionNova.WinUI.Reports
{
    public partial class frmNarudzbeReport : Form
    {
        private readonly APIService _service = new APIService("Narudzbe");
        public frmNarudzbeReport()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            dgv.AutoGenerateColumns = false;

        }
        string datumod = "01-01-2020";
        string datumdo = "1-1-2024";
        string brnarudzbe = "";
        private async void frmKreirajReport_Load(object sender, EventArgs e)
        {
               await LoadPodatke();
        }
        private async Task LoadPodatke()
        {
            var result = await _service.Get<List<FashionNova.Model.Models.Narudzba>>();
            dgv.DataSource = result;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            var request = new NarudzbeSearchRequest()
            {
               
                BrojNarudzbe = txtBrojNarudzbe.Text,
                DatumOD = datumod,
                DatumDO = datumdo

            };
            brnarudzbe = txtBrojNarudzbe.Text;
            var result = await _service.Get<List<FashionNova.Model.Models.Narudzba>>(request);
            dgv.DataSource = result;
        }

        private async void txtDatumOd_ValueChanged(object sender, EventArgs e)
        {
            var request = new NarudzbeSearchRequest()
            {
                BrojNarudzbe = brnarudzbe,
                DatumOD = txtDatumOd.Value.ToString(),
                DatumDO = datumdo

            };
            datumod = txtDatumOd.Value.ToString();
            var result = await _service.Get<List<FashionNova.Model.Models.Narudzba>>(request);
            dgv.DataSource = result;
        }

        private async void txtDatumDo_ValueChanged(object sender, EventArgs e)
        {
            var request = new NarudzbeSearchRequest() {
                BrojNarudzbe = brnarudzbe, 
                DatumOD = datumod, 
                DatumDO = txtDatumDo.Value.ToString() 
            };
            datumdo = txtDatumDo.Value.ToString();
            var result = await _service.Get<List<FashionNova.Model.Models.Narudzba>>(request);
            dgv.DataSource = result;
        }
        //Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        private  void btnPrintaj_Click(object sender, EventArgs e)
        {
            //Panel panel = new Panel();
            //this.Controls.Add(panel);
            //Graphics grp = panel.CreateGraphics();
            //Size formSize = this.ClientSize;
            //bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            //grp = Graphics.FromImage(bitmap);
            //Point panelLocation = PointToScreen(panel.Location);
            //grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            //printPreviewDialog1.ShowDialog();

            int height = dgv.Height;
            dgv.Height = dgv.RowCount * dgv.RowTemplate.Height * 2;
            bitmap = new Bitmap(dgv.Width, dgv.Height);
            dgv.DrawToBitmap(bitmap, new Rectangle(0, 0, dgv.Width, dgv.Height));
            dgv.Height = height;


            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

        }
    }
}
