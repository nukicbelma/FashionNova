using FashionNova.Model.Requests;
using FashionNovaWinUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FashionNova.WinUI.Klijenti
{
    public partial class frmKlijenti : Form
    {
        APIService _klijentiService = new APIService("Klijenti");
        public frmKlijenti()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            KlijentiSearchRequest searchRequest = new KlijentiSearchRequest()
            {
                Ime = txtPretraga.Text
            };
            var list = await _klijentiService.Get<List<FashionNova.Model.Models.Klijenti>>(searchRequest);
            dgvKlijenti.DataSource = list;
        }
    }
}
