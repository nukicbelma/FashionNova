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
    public partial class frmDodajVelicinu : Form
    {
        APIService _velicnaService = new APIService("Velicina");
        VelicinaInsertRequest insert = new VelicinaInsertRequest();
        public frmDodajVelicinu()
        {
            InitializeComponent();
            dgvVrste.AutoGenerateColumns = false;
        }

        private async void frmDodajVelicinu_Load(object sender, EventArgs e)
        {
            await LoadVrste();
        }
        private async Task LoadVrste()
        {
            var listaKorisnika = await _velicnaService.Get<List<Model.Models.Velicina>>();
            dgvVrste.DataSource = listaKorisnika;
        }

        private async void btnSacuvaj_Click_1(object sender, EventArgs e)
        {
            if (txtNaziv != null)
            {
                insert.Oznaka = txtNaziv.Text;
                await _velicnaService.Insert<Model.Models.Velicina>(insert);
                LoadVrste();
            }
        }
    }
}
