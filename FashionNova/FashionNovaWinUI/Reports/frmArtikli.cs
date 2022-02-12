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
    public partial class frmArtikli : Form
    {
        private readonly APIService _narudzbaStavke = new APIService("NarudzbaStavke");
        private readonly APIService _artikliService = new APIService("Artikli");
        private readonly APIService _narudzbeService = new APIService("Narudzbe");
        string datumod = "01-01-2020";
        string datumdo = "1-1-2024";
        public frmArtikli()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
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
        private async void LoadPodatke()
        {
            List<Model.Models.ArtikliReport> prodani = new List<Model.Models.ArtikliReport>();

            List<Model.Models.Artikli> listaArtikala = await _artikliService.Get<List<Model.Models.Artikli>>(null);

            List<Model.Models.NarudzbaStavke> listaNarudzbi = await _narudzbaStavke.Get<List<Model.Models.NarudzbaStavke>>(null);
            List<Model.Models.Narudzba> prvalista = await _narudzbeService.Get<List<Model.Models.Narudzba>>(null);

            foreach (var PRVA in prvalista)
            {
                if (PRVA.DatumNarudzbe >= Convert.ToDateTime(datumod) && PRVA.DatumNarudzbe <= Convert.ToDateTime(datumdo))
                {

                    foreach (var item1 in listaNarudzbi)
                    {

                        foreach (var item2 in listaArtikala)
                        {
                            if (item1.ArtikalId == item2.ArtikliId)
                            {

                                Model.Models.ArtikliReport novi = new Model.Models.ArtikliReport
                                {

                                    Cijena = item1.Cijena,
                                    Kolicina = item1.Kolicina,
                                    Naziv = item2.Naziv,
                                    Sifra = item2.Sifra,
                                    Ukupno = item1.Kolicina * item1.Cijena
                                };
                                var postoji = false;
                                foreach (var item3 in prodani)
                                {
                                    if (item3.Naziv.Equals(novi.Naziv))
                                    {
                                        postoji = true;
                                        item3.Kolicina += novi.Kolicina;
                                        item3.Ukupno += item3.Cijena * novi.Kolicina;
                                    }
                                }
                                if (postoji == false)
                                {
                                    prodani.Add(novi);
                                }
                            }

                        }
                    }
                }
            }

            dataGridView1.DataSource = prodani;
        }
        private void frmArtikli_Load(object sender, EventArgs e)
        {
            LoadPodatke();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
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

        private void txtDatumOd_ValueChanged(object sender, EventArgs e)
        {
            datumod = txtDatumOd.Value.ToString();
            LoadPodatke();
        }

        private void txtDatumDo_ValueChanged(object sender, EventArgs e)
        {
            datumdo = txtDatumDo.Value.ToString();
            LoadPodatke();
        }
    }
}
