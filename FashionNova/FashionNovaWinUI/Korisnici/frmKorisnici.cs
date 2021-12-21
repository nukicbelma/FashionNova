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

namespace FashionNova.WinUI.Korisnici
{
    public partial class frmKorisnici : Form
    {
        APIService _korisniciService = new APIService("Korisnici");
        public frmKorisnici()
        {
            InitializeComponent();
        }

        private async void frmKorisnici_Load(object sender, EventArgs e)
        {
            await LoadKorisnike();
        }
        private async Task LoadKorisnike()
        {
            var listaKorisnika = await _korisniciService.Get<List<Model.Models.Korisnici>>();
            dgvKorisnici.DataSource = listaKorisnika;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            KorisniciSearchRequest searchRequest = new KorisniciSearchRequest()
            {
                Ime = txtPretraga.Text
            };

            var list = await _korisniciService.Get<List<FashionNova.Model.Models.Korisnici>>(searchRequest);
            var prvi = list[0];

            dgvKorisnici.DataSource = list;
        }

        private void btnDodajKorisnika_Click(object sender, EventArgs e)
        {
            var forma = new frmDodajKorisnika();
            forma.ShowDialog();
            LoadKorisnike();
        }
        private Model.Models.Korisnici selectedKorisnik = null;
        private void dgvKorisnici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvKorisnici.SelectedRows[0].DataBoundItem;
            frmDodajKorisnika frm = new frmDodajKorisnika(item as FashionNova.Model.Models.Korisnici);
            frm.ShowDialog();
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvKorisnici.SelectedRows[0].DataBoundItem;
            frmDodajKorisnika frm = new frmDodajKorisnika(item as FashionNova.Model.Models.Korisnici);
            frm.ShowDialog();
        }
    }
}
