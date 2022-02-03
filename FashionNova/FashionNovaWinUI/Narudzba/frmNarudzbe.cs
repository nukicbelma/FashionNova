using FashionNova.Model.Requests;
using FashionNova.WinUI.Klijenti;
using FashionNovaWinUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionNova.WinUI.Narudzbe
{
    public partial class Narudzbe : Form
    {
        private readonly APIService _service = new APIService("Narudzbe");
        string datumod = "01-01-2020";
        string datumdo = "1-1-2024";
        string brnarudzbe = "";
        public Narudzbe()
        {
            InitializeComponent();
            dgvNarudzbe.AutoGenerateColumns = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvNarudzbe.SelectedRows[0].DataBoundItem as FashionNova.Model.Models.Narudzba;
            var detalji = new frmKlijentNarudzbaDetalji(item);
            detalji.ShowDialog();
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            var request = new NarudzbeSearchRequest()
            {

                BrojNarudzbe = txtBrojNarudzbe.Text,
                DatumOD = datumod,
                DatumDO = datumdo

            };
            brnarudzbe = txtBrojNarudzbe.Text;
            var result = await _service.Get<List<FashionNova.Model.Models.Narudzba>>(request);
            dgvNarudzbe.DataSource = result;
        }

        private async void Narudzbe_Load(object sender, EventArgs e)
        {
            await LoadDta();
        }

        private async void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var request = new NarudzbeSearchRequest()
            {
                BrojNarudzbe = brnarudzbe,
                DatumOD = datumod,
                DatumDO = dateTimePicker2.Value.ToString()
            };
            datumdo = dateTimePicker2.Value.ToString();
            var result = await _service.Get<List<FashionNova.Model.Models.Narudzba>>(request);
            dgvNarudzbe.DataSource = result;
        }

        private async void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            var request = new NarudzbeSearchRequest()
            {
                BrojNarudzbe = txtBrojNarudzbe.Text,
                DatumOD = dateTimePicker1.Value.ToString(),
                DatumDO = dateTimePicker2.Value.ToString(),
                //KlijentId = int.Parse("")

            };
            var result = await _service.Get<List<FashionNova.Model.Models.Narudzba>>(request);
            dgvNarudzbe.DataSource = result;
        }
        private async Task LoadDta()
        {
            
            var result = await _service.Get<List<FashionNova.Model.Models.Narudzba>>();
            dgvNarudzbe.DataSource = result;
        }
    }
}
