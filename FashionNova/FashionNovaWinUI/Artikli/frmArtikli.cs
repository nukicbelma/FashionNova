using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using FashionNova.WebAPI.Services;
using FashionNova.WinUI.Artikli;
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
        private readonly APIService _artikli = new APIService("Artikli");
        private readonly APIService _vrstaArtikla = new APIService("VrstaArtikla");
        private readonly APIService _boja = new APIService("Boja");
        private readonly APIService _velicina = new APIService("Velicina");
        public frmArtikli()
        {
            InitializeComponent();
            dgvArtikli.AutoGenerateColumns = false;
        }
        private async Task LoadData()
        {
            await LoadBoju();
            await LoadKategoriju();
            await LoadVelicinu();
        }
         private async Task LoadKategoriju(int vrstaArtiklaId=0)
        {
            var result = await _vrstaArtikla.Get<List<FashionNova.Model.Models.VrstaArtikla>>();
            result.Insert(0, new VrstaArtikla());
            cmbVrstaArtikla.DisplayMember = "Naziv";
            cmbVrstaArtikla.ValueMember = "VrstaArtiklaId";
            cmbVrstaArtikla.DataSource = result;
        }
        private async Task LoadVelicinu(int VelicinaId=0)
        {
            var result = await _velicina.Get<List<FashionNova.Model.Models.Velicina>>();
            result.Insert(0, new Velicina());
            cmbVelicina.DisplayMember = "Oznaka";
            cmbVelicina.ValueMember = "VelicinaId";
            cmbVelicina.DataSource = result;
        }
        private async Task LoadBoju(int BojaId=0)
        {
            var result = await _boja.Get<List<FashionNova.Model.Models.Boja>>();
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
            var result = await _artikli.Get<List<FashionNova.Model.Models.Artikli>>(search);
            dgvArtikli.DataSource = result;
        }
        private async void frmArtikli_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private void btnDodajArtikal_Click(object sender, EventArgs e)
        {
            var noviArtikal = new frmDodajUrediArtikal();
            noviArtikal.ShowDialog();
        }
        int vrstaArtiklaId = 0; int velicinaId = 0; int bojaId = 0;
        private async Task LoadProizvodi(int vrstaArtiklaId, int velicinaId, int bojaId)
        {
            ArtikliSearchRequest search = new ArtikliSearchRequest();
            search.IncludeList = new string[]
            {
               "Boja",
               "VrstaArtikla", 
               "Velicina", 
               "Naziv"
            };

            if (vrstaArtiklaId != 0 || velicinaId!=0 || bojaId!=0)
            {
                search.VrstaArtiklaId = vrstaArtiklaId;
                search.BojaId = bojaId;
                search.VelicinaId = velicinaId;
                search.Naziv = txtNaziv.Text.ToLower();
            }

            var result = await _artikli.Get<List<FashionNova.Model.Models.Artikli>>(search);
            dgvArtikli.DataSource = result;
        }
        private async void cmbBoja_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbBoja.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                bojaId = id;
                await LoadProizvodi(vrstaArtiklaId,velicinaId,id);
            }
        }

        private async void cmbVelicina_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbVelicina.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                velicinaId = id;
                await LoadProizvodi(vrstaArtiklaId, id, bojaId);
            }
        }

        private async void cmbVrstaArtikla_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbVrstaArtikla.SelectedValue;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                vrstaArtiklaId = id;
                await LoadProizvodi(id, velicinaId, bojaId);
            }
        }

        private async void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            ArtikliSearchRequest searchRequest = new ArtikliSearchRequest()
            {
                Naziv = txtNaziv.Text,
                BojaId=bojaId,
                VelicinaId=velicinaId,
                VrstaArtiklaId=vrstaArtiklaId
            };
            var list = await _artikli.Get<List<FashionNova.Model.Models.Artikli>>(searchRequest);
            dgvArtikli.DataSource = list;
        }
        private FashionNova.Model.Models.Artikli selectedArtikal = null;
        private void dgvArtikli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvArtikli.SelectedRows[0].DataBoundItem as FashionNova.Model.Models.Artikli;
            selectedArtikal = item;

            MessageBox.Show($"artikal id -> {selectedArtikal.ArtikliId}");
            var uredi = new frmDodajUrediArtikal(selectedArtikal);
            uredi.ShowDialog();

            //refreshanje dodanih/editovanih artikala
            LoadArtikle();
        }
    }
}
