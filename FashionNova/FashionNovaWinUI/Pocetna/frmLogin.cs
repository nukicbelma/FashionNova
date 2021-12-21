using FashionNova.Model.Requests;
using FashionNovaWinUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FashionNova.WinUI.Pocetna
{
    public partial class frmLogin : Form
    {
        private readonly APIService _korisniciService = new APIService("Korisnici");
        private readonly FashionNova.Database.FashionNova_IB170007Context _context;
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnPrijava_Click(object sender, EventArgs e)
        {
           FashionNova.Model.Models.Korisnici korisnik = await _korisniciService.Authenticiraj<FashionNova.Model.Models.Korisnici>(txtUsername.Text, txtPassword.Text);
            //int ulogaId1 = 0;

            if (korisnik != null)
            {
                //Global.PrijavljeniKorisnik = korisnik;
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;

                //foreach (var item in Global.PrijavljeniKorisnik.KorisniciUloge)
                //{
                //    ulogaId1 = item.UlogaId;

                //}
                //admin = await _serviceuloge.ProvjeriAdmin<Uloge>(ulogaId1);

                //if (admin != null)
                //{
                //    Global.Admin = true;
                //}

                var uloga = "uloga";
                if (korisnik.KorisniciUloge.FirstOrDefault().UlogaId == 1)
                {
                    uloga = "(admin)";
                    MessageBox.Show("Dobrodosli:: " + uloga + "->" + korisnik.Ime + " " + korisnik.Prezime);
                    var admin = new HomepageAdmin();
                    admin.ShowDialog();
                }
                else if (korisnik.KorisniciUloge.FirstOrDefault().UlogaId == 2)
                {
                    uloga = "(uposlenik)";
                    MessageBox.Show("Dobrodosli:: " + uloga + "->" + korisnik.Ime + " " + korisnik.Prezime);
                    var uposlenik = new HomepageUposlenik();
                    uposlenik.ShowDialog();
                }
            }

            else
            {
                MessageBox.Show("Pogresan username ili password", "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
