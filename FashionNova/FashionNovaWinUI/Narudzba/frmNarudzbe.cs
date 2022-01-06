using FashionNova.Model.Requests;
using FashionNovaWinUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FashionNova.WinUI.Narudzbe
{
    public partial class Narudzbe : Form
    {
        private readonly APIService _service = new APIService("Narudzbe");
        public Narudzbe()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            var request = new NarudzbeSearchRequest()
            {
                BrojNarudzbe = txtBrojNarudzbe.Text,
                DatumOD = dateTimePicker1.Value.ToString(),
                DatumDO = dateTimePicker2.Value.ToString()

            };
            var result = await _service.Get<List<FashionNova.Model.Models.Narudzba>>(request);
            dgvNarudzbe.DataSource = result;
        }

        private async void Narudzbe_Load(object sender, EventArgs e)
        {
            var result = await _service.Get<List<FashionNova.Model.Models.Narudzba>>();
            dgvNarudzbe.DataSource = result;
        }

        private async void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var request = new NarudzbeSearchRequest()
            {
                BrojNarudzbe = txtBrojNarudzbe.Text, 
                DatumOD=dateTimePicker1.Value.ToString(),
                DatumDO=dateTimePicker2.Value.ToString()

            };
            var result = await _service.Get<List<FashionNova.Model.Models.Narudzba>>(request);
            dgvNarudzbe.DataSource = result;
        }

        private async void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            var request = new NarudzbeSearchRequest()
            {
                BrojNarudzbe = txtBrojNarudzbe.Text,
                DatumOD = dateTimePicker1.Value.ToString(),
                DatumDO = dateTimePicker2.Value.ToString()

            };
            var result = await _service.Get<List<FashionNova.Model.Models.Narudzba>>(request);
            dgvNarudzbe.DataSource = result;
        }
    }
}
