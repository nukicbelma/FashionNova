using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using FashionNova.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FashionNovaWinUI.Artikli
{
    public partial class frmArtikli : Form
    {
        APIService  _artikliService = new APIService("Artikli");
        APIService _vrstaArtiklaService = new APIService("VrstaArtikla");
        APIService _velicinaService = new APIService("Velicina");
        APIService _bojaService = new APIService("Boja");
        public frmArtikli()
        {
            InitializeComponent();
            //dgvArtikli.AutoGenerateColumns = false;
        }
        private async Task LoadData()
        {
            await LoadArtikle();
            await LoadBoju();
            await LoadKategoriju();
            await LoadVelicinu();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void cmbVrstaArtikla_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbVrstaArtikla.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadKategoriju(id);
            }
        }
         private async Task LoadKategoriju(int vrstaArtiklaId=0)
        {
            var result = await _vrstaArtiklaService.Get<List<FashionNova.Model.Models.VrstaArtikla>>();
            result.Insert(0, new VrstaArtikla());
            cmbVrstaArtikla.DisplayMember = "Naziv";
            cmbVrstaArtikla.ValueMember = "VrstaId";
            cmbVrstaArtikla.DataSource = result;
        }
        private async Task LoadVelicinu(int VelicinaId=0)
        {
            var result = await _velicinaService.Get<List<FashionNova.Model.Models.Velicina>>();
            result.Insert(0, new Velicina());
            cmbVelicina.DisplayMember = "Oznaka";
            cmbVelicina.ValueMember = "VelicinaId";
            cmbVelicina.DataSource = result;
        }
        private async Task LoadBoju(int BojaId=0)
        {
            var result = await _bojaService.Get<List<FashionNova.Model.Models.Boja>>();
            result.Insert(0, new Boja());
            cmbBoja.DisplayMember = "Naziv";
            cmbBoja.ValueMember = "BojaId";
            cmbBoja.DataSource = result;
        }
        private async Task LoadArtikle()
        {
            //dgvArtikli.AutoGenerateColumns = false;
            var search = new ArtikliSearchRequest()
            {
                Naziv = txtNaziv.Text
            };

            var result = await _artikliService.Get<List<FashionNova.Model.Models.Artikli>>(search);
            dgvArtikli.DataSource = result;
        }
        private void dgvArtikli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void frmArtikli_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void cmbVelicina_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbVelicina.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadVelicinu(id);
            }
        }

        private async void cmbBoja_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbBoja.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadBoju(id);
            }
        }
    }
}
