using FashionNova.Model.Models;
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
        private readonly APIService _serviceuloge = new APIService("Uloge");
        Uloge admin = null;

        private readonly FashionNova.WebAPI.Database.IB170007Context _context;
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        private async void btnPrijava_Click(object sender, EventArgs e)
        {
           FashionNova.Model.Models.Korisnici korisnik = await _korisniciService.Authenticiraj<FashionNova.Model.Models.Korisnici>(txtUsername.Text, txtPassword.Text);
            int ulogaId1 = 0;

            if (korisnik != null)
            {
                PrijavljeniKorisnikService.PrijavljeniKorisnik = korisnik;
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;

                foreach (var item in PrijavljeniKorisnikService.PrijavljeniKorisnik.KorisniciUloge)
                {
                    ulogaId1 = item.UlogeId;

                }
                admin = await _serviceuloge.ProvjeriAdmin<Uloge>(ulogaId1);

                if (admin != null)
                {
                    PrijavljeniKorisnikService.Admin = true;
                }
                MessageBox.Show("Dobrodosli " + korisnik.Ime + " " + korisnik.Prezime);
                DialogResult = DialogResult.OK;
               
                if(korisnik.KorisniciUloge.FirstOrDefault().UlogeId==1)
                {
                    var admin = new HomepageAdmin();
                    admin.ShowDialog();
                }
                else if(korisnik.KorisniciUloge.FirstOrDefault().UlogeId==2)
                {
                    var uposlenik = new HomepageUposlenik();
                    uposlenik.ShowDialog();
                }
                Close();
                //var uloga = "uloga";
                //if (korisnik.KorisniciUloge.FirstOrDefault().UlogaId == 1)
                //{
                //    uloga = "(admin)";
                //    MessageBox.Show("Dobrodosli:: " + uloga + "->" + korisnik.Ime + " " + korisnik.Prezime);
                //    var admin = new HomepageAdmin();
                //    admin.ShowDialog();
                //    Close();

                //}
                //else if (korisnik.KorisniciUloge.FirstOrDefault().UlogaId == 2)
                //{
                //    uloga = "(uposlenik)";
                //    MessageBox.Show("Dobrodosli:: " + uloga + "->" + korisnik.Ime + " " + korisnik.Prezime);
                //    var uposlenik = new HomepageUposlenik();
                //    uposlenik.ShowDialog();
                //    Close();
                //}
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
