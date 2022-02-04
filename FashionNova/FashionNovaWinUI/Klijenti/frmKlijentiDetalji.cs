using FashionNova.Model.Requests;
using FashionNovaWinUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionNova.WinUI.Klijenti
{
    public partial class frmKlijentiDetalji : Form
    {
        private Model.Models.Klijenti klijent;
        private KlijentiInsertRequest update = new KlijentiInsertRequest();
        APIService _narudzbeService = new APIService("Narudzbe");
        public frmKlijentiDetalji(Model.Models.Klijenti klijent)
        {
            InitializeComponent();
            this.klijent = klijent;
            dataGridView1.AutoGenerateColumns = false;
        }

        private async void frmKlijentiDetalji_Load(object sender, EventArgs e)
        {
            await ucitajPodatke();
            await LoadData();
        }
        private async Task ucitajPodatke()
        {
            txtnaslov.Text = klijent.KorisnickoIme;
            txtImePrezime.Text = klijent.Ime + " " + klijent.Prezime;
            txtEmail.Text = klijent.Email;
            txtTelefon.Text = klijent.Telefon;
            txtKorisnickoIme.Text = klijent.KorisnickoIme;
            //if (klijent.Slika != null)
            //{
            //    pbxSlika.Image = FashionNova.WinUI.Helpers.ImageHelper.FromByteToImage(File.ReadAllBytes("Resources/profilna1.jpg"));
            //}
        }
        private async Task LoadData()
        {
            var request = new NarudzbeSearchRequest()
            {
                KlijentId = klijent.KlijentId
            };
            var result = await _narudzbeService.Get<List<FashionNova.Model.Models.Narudzba>>(request);
            dataGridView1.DataSource = result;
        }
        private async Task pretraga()
        {
            var request = new NarudzbeSearchRequest()
            {
                KlijentId = klijent.KlijentId, 
                BrojNarudzbe=txtPretraga.Text
            };
            var result = await _narudzbeService.Get<List<FashionNova.Model.Models.Narudzba>>(request);
            dataGridView1.DataSource = result;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dataGridView1.SelectedRows[0].DataBoundItem as FashionNova.Model.Models.Narudzba;
            var detalji = new frmKlijentNarudzbaDetalji(item);
            detalji.ShowDialog();
        }

        private   async void txtPretraga_TextChanged(object sender, EventArgs e)
        {
           await  pretraga();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
