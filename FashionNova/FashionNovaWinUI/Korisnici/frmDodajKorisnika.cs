using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using FashionNova.WinUI.Properties;
using FashionNovaWinUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionNova.WinUI.Korisnici
{
    public partial class frmDodajKorisnika : Form
    {
        APIService korisniciService = new APIService("Korisnici");
        APIService ulogeService = new APIService("Uloge");

        private Model.Models.Korisnici selectedKorisnik;

        private FashionNova.Model.Models.Korisnici   _korisnik;
        public frmDodajKorisnika(FashionNova.Model.Models.Korisnici korisnik = null)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private async void btnSpasi_Click(object sender, EventArgs e)
        {
            if (_korisnik == null)
            {
                var ulogeList = await ulogeService.Get<List<Model.Models.KorisniciUloge>>(null);
                var listUloge = new List<KorisniciUloge>();
                KorisniciInsertRequest request = new KorisniciInsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Email = txtEmail.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtLozinka.Text,
                    PasswordPotvrda = txtPotvrdaLozinke.Text,
                    Telefon = txtTelefon.Text,
                    Slika = Helpers.ImageHelper.FromImageToByte(pbxSlika.Image),
                   
                };
                var korisnik = await korisniciService.Insert<FashionNova.Model.Models.Korisnici>(request);
            }
            else
            {
                //update
                KorisniciUpdateRequest request = new KorisniciUpdateRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Email = txtEmail.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtLozinka.Text,
                    PasswordPotvrda = txtPotvrdaLozinke.Text,
                    Telefon = txtTelefon.Text,
                    Slika = Helpers.ImageHelper.FromImageToByte(pbxSlika.Image)
                };
                if(pbxSlika.Image==null)
                {
                    request.Slika = Helpers.ImageHelper.FromImageToByte(Resources.profilna1);
                }
                var korisnik = await korisniciService.Update<FashionNova.Model.Models.Korisnici>(_korisnik.KorisniciId, request);

            }
            MessageBox.Show("Uspjesno ste dodali novog korisnika.");
            Close();
        }
        private async void frmDodajKorisnika_Load(object sender, EventArgs e)
        {
            await LoadUloge();
            if (_korisnik != null)
            {
                MessageBox.Show($"Korisnik: {_korisnik.Ime}");
                txtIme.Text = _korisnik.Ime;
                txtPrezime.Text = _korisnik.Prezime;
                txtKorisnickoIme.Text = _korisnik.KorisnickoIme;
                txtEmail.Text = _korisnik.Email;
                txtTelefon.Text = _korisnik.Telefon;
                txtSlika.Text = _korisnik.Slika.ToString();
                if (_korisnik.Slika != null)
                {
                    pbxSlika.Image = FashionNova.WinUI.Helpers.ImageHelper.FromByteToImage(_korisnik.Slika);
                }
                else
                    pbxSlika.Image = null;
            }
        }

        private async Task LoadUloge()
        {
            var uloge = await ulogeService.Get<List<Uloge>>();
            cmbUloge.DataSource = uloge;
            cmbUloge.DisplayMember = "Naziv";
        }

        private void pbxSlika_Click(object sender, EventArgs e)
        {
            var result = ofdSlika.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = ofdSlika.FileName;
                var file = File.ReadAllBytes(fileName);
                txtSlika.Text = fileName;
                pbxSlika.Image = Image.FromFile(fileName);
            }
        }

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            var result = ofdSlika.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = ofdSlika.FileName;
                var file = File.ReadAllBytes(fileName);
                txtSlika.Text = fileName;
                pbxSlika.Image = Image.FromFile(fileName);
            }
        }
    }
}