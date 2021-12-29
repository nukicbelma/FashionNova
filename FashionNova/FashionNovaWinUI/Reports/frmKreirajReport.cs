using FashionNova.Model.Requests;
using FashionNovaWinUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionNova.WinUI.Reports
{
    public partial class frmKreirajReport : Form
    {
        private string str;
        private readonly APIService _service = new APIService("Narudzba");
        public frmKreirajReport(string str)
        {
            InitializeComponent();
            this.str = str;
        }

        private async void frmKreirajReport_Load(object sender, EventArgs e)
        {
            txtIzvjestaj.Text = str;
            if (str == "narudzbi")
            {
               await LoadPodatke();
            }
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
                DatumOD = txtDatumOd.Value.ToString(),
                DatumDO = txtDatumDo.Value.ToString()

            };
            var result = await _service.Get<List<FashionNova.Model.Models.Narudzba>>(request);
            dgv.DataSource = result;
        }

        private async void txtDatumOd_ValueChanged(object sender, EventArgs e)
        {
            var request = new NarudzbeSearchRequest()
            {
                BrojNarudzbe = txtBrojNarudzbe.Text,
                DatumOD = txtDatumOd.Value.ToString(),
                DatumDO = txtDatumDo.Value.ToString()

            };
            var result = await _service.Get<List<FashionNova.Model.Models.Narudzba>>(request);
            dgv.DataSource = result;
        }

        private async void txtDatumDo_ValueChanged(object sender, EventArgs e)
        {
            var request = new NarudzbeSearchRequest() {
                BrojNarudzbe = txtBrojNarudzbe.Text, 
                DatumOD = txtDatumOd.Value.ToString(), 
                DatumDO = txtDatumDo.Value.ToString() 
            };
            var result = await _service.Get<List<FashionNova.Model.Models.Narudzba>>(request);
            dgv.DataSource = result;
        }
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawImage(bmp, 0, 0);
        }
        private async void btnPrintaj_Click(object sender, EventArgs e)
        {
            var result = await _service.Get<List<FashionNova.Model.Models.Narudzba>>();
            dgv.DataSource = result;

            int height = dgv.Height;
            dgv.Height = dgv.RowCount * dgv.RowTemplate.Height * 2;
            bmp = new Bitmap(dgv.Width, dgv.Height);
            dgv.DrawToBitmap(bmp, new Rectangle(0, 0, dgv.Width, dgv.Height));
            dgv.Height = height;
            printPreviewDialog1.ShowDialog();
        }
    }
}
