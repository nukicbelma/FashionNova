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

namespace FashionNova.WinUI.MaterijalBojaVelicinaVrsta
{
    public partial class frmDodajBoju : Form
    {
        APIService _bojaService = new APIService("Boja");
        VrstaArtiklaInsertRequest insert = new VrstaArtiklaInsertRequest();
        public frmDodajBoju()
        {
            InitializeComponent();
            dgvVrste.AutoGenerateColumns = false;
        }

        private async void frmDodajBoju_Load(object sender, EventArgs e)
        {
            await LoadVrste();
        }
        private async Task LoadVrste()
        {
            var listaKorisnika = await _bojaService.Get<List<Model.Models.Boja>>();
            dgvVrste.DataSource = listaKorisnika;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (txtNaziv == null || txtNaziv.Text=="")
                errorProvider1.SetError(txtNaziv, "Prazno polje!!");
            else if (txtNaziv != null || txtNaziv.Text!="")
            {
                bool postoji = false;
                var listaboja = await _bojaService.Get<List<Model.Models.Boja>>();
                foreach (var item in listaboja)
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
                    await _bojaService.Insert<Model.Models.Boja>(insert);
                    MessageBox.Show("Stavka uspjesno dodana.");
                    await LoadVrste();
                }
            }
        }
    }
}
