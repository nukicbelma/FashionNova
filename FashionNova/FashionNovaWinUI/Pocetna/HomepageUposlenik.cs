using FashionNova.WinUI.Klijenti;
using FashionNova.WinUI.Narudzbe;
using FashionNova.WinUI.Reports;
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
            var formaNarudzbe = new Narudzbe.Narudzbe();
            formaNarudzbe.ShowDialog();
        }

        private void btnIzvjestaji_Click(object sender, EventArgs e)
        {
            var frm = new frmIndexReport();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new frmConfirmationOdjava();
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                Close();
                PrijavljeniKorisnikService.PrijavljeniKorisnik = null;
                var loginPonovo = new frmLogin();
                loginPonovo.ShowDialog();
            }
        }
    }
}
