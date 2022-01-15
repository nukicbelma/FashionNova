using FashionNova.Model.Models;
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

namespace FashionNova.WinUI.Klijenti
{
    public partial class frmKlijentNarudzbaDetalji : Form
    {
        private Narudzba item;
        APIService _narudzbeStavkeService = new APIService("NarudzbaStavke");
        APIService _narudzbe = new APIService("Narudzba");
        public frmKlijentNarudzbaDetalji(Narudzba item)
        {
            this.item = item;
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private async Task LoadNarudzbe()
        {
            var request = new NarudzbeSearchRequest()
            {
                KlijentId = item.KlijentId,
                BrojNarudzbe=item.BrojNarudzbe,
                NarudzbaId=item.NarudzbaId
            };
            List<Model.Models.NarudzbaStavke> stavke = await _narudzbeStavkeService.Get<List<Model.Models.NarudzbaStavke>>(null);

            List<Model.Models.NarudzbaStavke> result = new List<Model.Models.NarudzbaStavke>();
            foreach (var s in stavke)
            {
                Model.Models.NarudzbaStavke nova = new Model.Models.NarudzbaStavke();

                if (item.NarudzbaId == item.NarudzbaId)
                {
                    nova.ArtikalId = s.ArtikalId;
                    nova.Cijena = s.Cijena;
                    nova.Kolicina = s.Kolicina;
                    nova.NarudzbaStavkeId = s.NarudzbaStavkeId;
                    nova.Sifra = s.Sifra;
                    nova.Popust = s.Popust;
                    nova.NazivArtikla = s.NazivArtikla;
                    nova.NarudzbaId = item.NarudzbaId;

                    result.Add(nova);
                }
            }
            dataGridView1.DataSource = result; 
        }
        private async void frmKlijentNarudzbaDetalji_Load(object sender, EventArgs e)
        {
            txtKorisnik.Text = item.Korisnik;
            txtKlijent.Text = item.Klijent;
            txtIznosSaPDV.Text = item.IznosSaPdv.ToString();
            txtiznosbezpdv.Text = item.IznosBezPdv.ToString();
            txtDatumNarudzbe.Text = item.DatumNarudzbe.ToString();
            txtBrjNarudzbe.Text = item.BrojNarudzbe;

            await LoadNarudzbe();
        }
    }
}
