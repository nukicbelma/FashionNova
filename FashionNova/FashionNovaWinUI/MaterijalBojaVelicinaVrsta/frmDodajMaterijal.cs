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
    public partial class frmDodajMaterijal : Form
    {
        APIService _materijali = new APIService("Materijal");
        MaterijalInsertRequest insert = new MaterijalInsertRequest();
        public frmDodajMaterijal()
        {
            InitializeComponent();
            dgvVrste.AutoGenerateColumns = false;
        }

        private async void frmDodajMaterijal_Load(object sender, EventArgs e)
        {
            await LoadVrste();
        }
        private async Task LoadVrste()
        {
            var listaKorisnika = await _materijali.Get<List<Model.Models.Materijal>>();
            dgvVrste.DataSource = listaKorisnika;
        }
        private async void btnSacuvaj_Click_1(object sender, EventArgs e)
        {
            if (txtNaziv != null)
            {
                insert.Naziv = txtNaziv.Text;
                await _materijali.Insert<Model.Models.Materijal>(insert);
                LoadVrste();
            }
        }
    }
}
