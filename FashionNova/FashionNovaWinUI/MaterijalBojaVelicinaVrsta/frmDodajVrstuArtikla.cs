using FashionNova.Model.Requests;
using FashionNovaWinUI;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionNova.WinUI.MaterijalBojaVelicinaVrsta
{
    public partial class frmDodajVrstuArtikla : Form
    {
        APIService _vrsteArtikliService = new APIService("VrstaArtikla");
        VrstaArtiklaInsertRequest insert = new VrstaArtiklaInsertRequest();
        public frmDodajVrstuArtikla()
        {
            InitializeComponent();
            dgvVrste.AutoGenerateColumns= false;
        }

        private async void frmDodajVrstuArtikla_Load(object sender, EventArgs e)
        {
            await LoadVrste();
        }
        private async Task LoadVrste()
        {
            var listaKorisnika = await _vrsteArtikliService.Get<List<Model.Models.VrstaArtikla>>();
            dgvVrste.DataSource = listaKorisnika;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (txtNaziv == null || txtNaziv.Text == "")
                errorProvider1.SetError(txtNaziv, "Prazno polje!!");
            else if (txtNaziv != null || txtNaziv.Text != "")
            {
                bool postoji = false;
                var listavrsta = await _vrsteArtikliService.Get<List<Model.Models.VrstaArtikla>>();
                foreach (var item in listavrsta)
                {
                    if (item.Naziv.ToLower() == txtNaziv.Text.ToLower())
                    {
                        postoji = true;
                        errorProvider1.SetError(txtNaziv, "Naziv vec postoji u bazi.");
                    }
                }
                if (!postoji)
                {
                    insert.Naziv = txtNaziv.Text;
                    await _vrsteArtikliService.Insert<Model.Models.VrstaArtikla>(insert);
                    MessageBox.Show("Stavka uspjesno dodana.");
                    await LoadVrste();
                }
            }
        }

        private void dgvVrste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
