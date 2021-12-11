using FashionNova.Model.Models;
using FashionNova.Model.Requests;
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
                //var ulogeList = clbUloge.CheckedItems.Cast<Uloge>();
                //var ulogeIdList = ulogeList.Select(x => x.UlogaId).ToList();
                //insert
                KorisniciInsertRequest request = new KorisniciInsertRequest()
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Email = txtEmail.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Password = txtLozinka.Text,
                    PasswordPotvrda=txtPotvrdaLozinke.Text,
                    Telefon=txtTelefon.Text,
                    Slika= Helpers.ImageHelper.FromImageToByte(pbxSlika.Image)
                    //Status = chkStatus.Checked,
                    //Uloge = ulogeIdList
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
                    //Status = chkStatus.Checked
                };

                var korisnik = await korisniciService.Update<FashionNova.Model.Models.Korisnici>(_korisnik.KorisnikId, request);

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
                pbxSlika.Image = FashionNova.WinUI.Helpers.ImageHelper.FromByteToImage(_korisnik.Slika);
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