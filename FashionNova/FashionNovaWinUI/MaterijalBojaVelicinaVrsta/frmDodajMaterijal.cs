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
            if (txtNaziv == null || txtNaziv.Text == "")
                errorProvider1.SetError(txtNaziv, "Prazno polje!!");
            else if (txtNaziv != null || txtNaziv.Text != "")
            {
                bool postoji = false;
                var listamaterijala = await _materijali.Get<List<Model.Models.Materijal>>();
                foreach (var item in listamaterijala)
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
                    await _materijali.Insert<Model.Models.Materijal>(insert);
                    MessageBox.Show("Stavka uspjesno dodana.");
                    await LoadVrste();
                }
            }
        }
    }
}
