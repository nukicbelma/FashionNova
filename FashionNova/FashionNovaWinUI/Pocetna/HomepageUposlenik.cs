using FashionNova.WinUI.Klijenti;
using FashionNova.WinUI.Narudzbe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FashionNova.WinUI.Pocetna
{
    public partial class HomepageUposlenik : Form
    {
        public HomepageUposlenik()
        {
            InitializeComponent();
        }

        private void HomepageUposlenik_Load(object sender, EventArgs e)
        {
            LoadDatumVrijeme();
        }
        private  void LoadDatumVrijeme()
        {
            lblDatumiVrijeme.Text =  DateTime.Now.ToString();
        }

        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            var formaKlijenti = new frmKlijenti();
            formaKlijenti.ShowDialog();
        }

        private void btnNarudzbe_Click(object sender, EventArgs e)
        {
            var formaNarudzbe = new frmNarudzbe();
            formaNarudzbe.ShowDialog();
        }
    }
}
