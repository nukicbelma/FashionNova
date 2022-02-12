using FashionNova.Model.Models;
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
    public partial class frmArtikalOcjenaReport : Form
    {
        private readonly APIService _service = new APIService("Ocjene");
        private readonly APIService _artikliService = new APIService("Artikli");
        public frmArtikalOcjenaReport()
        {
            InitializeComponent();
           printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
           dataGridView1.AutoGenerateColumns = false;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;
        private async Task LoadPodatke()
        {
            var result = await _service.Get<List<FashionNova.Model.Models.Ocjene>>();
            dataGridView1.DataSource = result;
        }
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        private void btnPrintaj_Click(object sender, EventArgs e)
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

            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Height = height;


            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

        }
        private async void frmArtikalReport_Load(object sender, EventArgs e)
        {
          await LoadPodatke();
          await LoadKategoriju();
        }

        private void btnPrintaj_Click_1(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Height = height;


            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
        private async Task LoadKategoriju(int ArtikalId = 0)
        {
            var result = await _artikliService.Get<List<FashionNova.Model.Models.Artikli>>();
            result.Insert(0, new Model.Models.Artikli());
            cmbVrstaArtikla.DisplayMember = "Naziv";
            cmbVrstaArtikla.ValueMember = "ArtikliId";
            cmbVrstaArtikla.DataSource = result;
        }
        private readonly APIService _vrstaArtikla = new APIService("VrstaArtikla");
        int artikalId = 0;
        private  async void cmbVrstaArtikla_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbVrstaArtikla.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                artikalId = id;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //if(artikalId!=0)
            {
                OcjeneSearchRequest search = new OcjeneSearchRequest();
                search.ArtikliId = artikalId;
                var result = await _service.Get<List<FashionNova.Model.Models.Ocjene>>(search);
                dataGridView1.DataSource = result;
            }
        }
    }
}
