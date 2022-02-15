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
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionNova.WinUI.Korisnici
{
    public partial class frmDodajKorisnika : Form
    {
        APIService korisniciService = new APIService("Korisnici");
        APIService ulogeService = new APIService("Uloge");
        APIService korisniciUlogeService = new APIService("KorisniciUloge");

        private Model.Models.Korisnici selectedKorisnik;

        private FashionNova.Model.Models.Korisnici   _korisnik;
        public frmDodajKorisnika(FashionNova.Model.Models.Korisnici korisnik = null)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }
        public bool IsValidEmailAddress(string email)
        {
            try
            {
                MailAddress ma = new MailAddress(email);

                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool ValidateContact(string broj)
        {
            return (System.Text.RegularExpressions.Regex.IsMatch("[^0-9]", broj));
        }

        private async void btnSpasi_Click(object sender, EventArgs e)
        {
            if (_korisnik == null)
            {
                var newList = new List<int>();
                newList.Add(cmbUloge.SelectedIndex);
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
                    Uloge=newList
                };
                bool postojiUsername = false;
                var listakorsnika = await korisniciService.Get<List<Model.Models.Korisnici>>(null);
                foreach (var item in listakorsnika)
                {
                    if (item.KorisnickoIme.ToLower() == request.KorisnickoIme)
                        postojiUsername = true;
                }
               
                if (txtPrezime.Text == "" || txtTelefon.Text == "" || txtEmail.Text == "" || txtIme.Text == "" ||
                    txtPotvrdaLozinke.Text == "" || txtLozinka.Text == "" || txtPrezime.Text.Length < 2 || txtIme.Text.Length < 2 || cmbUloge.SelectedIndex==0)
                {
                    MessageBox.Show("Niste unijeli sva polja ispravno. Pokusajte ponovo. (Polje prazno/ne sadrzi dovoljan broj karaktera)");
                }
                else if (!IsValidEmailAddress(txtEmail.Text))
                {
                    MessageBox.Show("Format emaila nije validan. ->primjer@email.com");
                }
                else if(ValidateContact(txtTelefon.Text) || txtTelefon.Text.Length > 10 || txtTelefon.Text.Length < 9)
                {
                    errorProvider1.SetError(txtTelefon, "Broj nije validan. Unesite 9 ili 10tocifreni broj bez karaktera-> 062963147");
                }
                else if (txtLozinka.Text != txtPotvrdaLozinke.Text || txtLozinka.Text.Length < 4)
                {
                    errorProvider1.SetError(txtLozinka, "Passwordi se ne slazu ili moraju sadrzavati minimalno 4 karaktera.");
                }
                else if (postojiUsername)

                {
                    errorProvider1.SetError(txtKorisnickoIme, "Korisnik sa tim korisnickim imenom vec postoji.");
                }
                else
                {
                    var korisnik = await korisniciService.Insert<FashionNova.Model.Models.Korisnici>(request);
                    MessageBox.Show("Uspjesno ste dodali novog korisnika.");
                    Close();
                }
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
                bool postojiUsername = false;
                var listakorsnika = await korisniciService.Get<List<Model.Models.Korisnici>>(null);
                foreach (var item in listakorsnika)
                {
                    if (item.KorisnickoIme.ToLower() == request.KorisnickoIme && _korisnik.KorisniciId != item.KorisniciId)
                        postojiUsername = true;
                }
                if (txtPrezime.Text == "" || txtTelefon.Text == "" || txtEmail.Text == "" || txtIme.Text == "" || 
                    txtPotvrdaLozinke.Text == "" || txtLozinka.Text == "" || txtPrezime.Text.Length<2 || txtIme.Text.Length<2 || cmbUloge.SelectedIndex==0)
                {
                    MessageBox.Show("Niste unijeli sva polja ispravno. Pokusajte ponovo. (Polje prazno/ne sadrzi dovoljan broj karaktera)");
                }
                else if (!IsValidEmailAddress(txtEmail.Text))
                {
                    MessageBox.Show("Format emaila nije validan. ->primjer@email.com");
                }
                else if (ValidateContact(txtTelefon.Text) || txtTelefon.Text.Length > 10 || txtTelefon.Text.Length < 9)
                {
                    errorProvider1.SetError(txtTelefon, "Broj nije validan. Unesite 9 ili 10tocifreni broj bez karaktera-> 062963147");
                }
                else if (txtLozinka.Text != txtPotvrdaLozinke.Text || txtLozinka.Text.Length<4)
                {
                    errorProvider1.SetError(txtLozinka, "Passwordi se ne slazu ili moraju sadrzavati minimalno 4 karaktera.");
                }
                else if (postojiUsername)
                {
                    errorProvider1.SetError(txtKorisnickoIme, "Korisnik sa tim korisnickim imenom vec postoji.");
                }
                else
                {
                    var korisnik = await korisniciService.Update<FashionNova.Model.Models.Korisnici>(_korisnik.KorisniciId, request);
                    MessageBox.Show("Uspjesno ste editovali postojeceg korisnika.");
                    Close();
                }
            }

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
                pbxSlika.Image = FashionNova.WinUI.Helpers.ImageHelper.FromByteToImage(_korisnik.Slika);
                
                var lista = await korisniciUlogeService.Get<List<KorisniciUloge>>();
                foreach (var item in lista)
                {
                    if (_korisnik.KorisniciId == item.KorisniciId)
                        cmbUloge.SelectedIndex = item.UlogeId;
                }
            }
        }

        private async Task LoadUloge()
        {
            var result = await ulogeService.Get<List<FashionNova.Model.Models.Uloge>>();
            result.Insert(0, new Uloge());
            cmbUloge.DisplayMember = "Naziv";
            cmbUloge.ValueMember = "BojaId";
            cmbUloge.DataSource = result;
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