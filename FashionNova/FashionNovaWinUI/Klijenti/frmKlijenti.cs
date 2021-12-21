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
    public partial class frmKlijenti : Form
    {
        APIService _klijentiService = new APIService("Klijenti");
        public frmKlijenti()
        {
            InitializeComponent();
            dgvKlijenti.AutoGenerateColumns = false;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            KlijentiSearchRequest searchRequest = new KlijentiSearchRequest()
            {
                Ime = txtIme.Text
            };
            var list = await _klijentiService.Get<List<FashionNova.Model.Models.Klijenti>>(searchRequest);
            // var prvi = list[0];
            dgvKlijenti.DataSource = list;
        }

        private async void frmKlijenti_Load(object sender, EventArgs e)
        {
            await LoadKlijente();
        }
        private async Task LoadKlijente()
        {
            var listaKorisnika = await _klijentiService.Get<List<Model.Models.Klijenti>>();
            dgvKlijenti.DataSource = listaKorisnika;
        }
        private FashionNova.Model.Models.Klijenti klijent = null;
        private async void dgvKlijenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvKlijenti.SelectedRows[0].DataBoundItem as FashionNova.Model.Models.Klijenti;
            klijent = item;
            var detalji = new frmKlijentiDetalji(klijent);
            detalji.ShowDialog();
        }
    }
}
