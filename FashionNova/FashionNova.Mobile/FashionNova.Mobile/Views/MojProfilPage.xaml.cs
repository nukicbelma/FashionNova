using FashionNova.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FashionNova.Model;
using FashionNova.Model.Models;
using FashionNova.Mobile.Services;
using System.IO;

namespace FashionNova.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MojProfilPage : ContentPage
    {
        MojProfilViewModel model = null;
        APIService _serviceklijenti = new APIService("Klijenti");
        public MojProfilPage()
        {
            InitializeComponent();
            BindingContext = model = new MojProfilViewModel();
            inputIme.Text = PrijavljeniKlijentService.PrijavljeniKlijent.Ime;
            inputKlijentId.Text = PrijavljeniKlijentService.PrijavljeniKlijent.KlijentiId.ToString();
            inputPrezime.Text = PrijavljeniKlijentService.PrijavljeniKlijent.Prezime;
            inputEmail.Text = PrijavljeniKlijentService.PrijavljeniKlijent.Email;
            inputPassword.Text = "";
            inputPotvrda.Text = "";
            inputKorisnickoIme.Text = PrijavljeniKlijentService.PrijavljeniKlijent.KorisnickoIme;
            inputTelefon.Text = PrijavljeniKlijentService.PrijavljeniKlijent.Telefon;
            var stream1 = new MemoryStream(PrijavljeniKlijentService.PrijavljeniKlijent.Slika);
            ProfilePhoto.Source = ImageSource.FromStream(() => stream1);
        }
        private async void ButtonUploadSliku_Clicked(object sender, EventArgs e)
        {
            await model.UploadProfilePicture();
            ProfilePhoto.Source = model.ProfilePhotoSource;
        }
        private async void ButtonEditKlijent_Clicked(object sender, EventArgs e)
        {
            bool dupliemail = false;

            List<Klijenti> lista = await _serviceklijenti.Get<List<Klijenti>>(null);

            foreach (var item in lista)
            {
                if (item.Email.Equals(inputEmail.Text) == true && item.KlijentiId.ToString()!=inputKlijentId.Text)
                {
                    dupliemail = true;
                }
            }
            if (validateIzmjene() == true)
            {
                if (dupliemail == true)
                {
                    await DisplayAlert("Greska", "Korisnik sa tim emailom je vec registrovan", "OK");
                    emailError.Text = "Email vec postoji!";
                    emailError.IsVisible = true;
                }
                else
                {
                    await model.EditujKlijenta();
                    Application.Current.MainPage = new PocetnaPage();
                }
            }
            else
            {
                await DisplayAlert("Greska", "Niste unijeli sva polja.", "OK");
            }
        }
        private bool validateIzmjene()
        {
            bool valid = true;
            //radim odvojeno kako bi dobio odma error border za svaki pogresan unos
            if (validateIme() == false)
                valid = false;
            if (validatePrezime() == false)
                valid = false;
            if (validateEmail() == false)
                valid = false;
            if (validateLozinka() == false)
                valid = false;
            if (validateTelefon() == false)
                valid = false;
            if (validateLozinka() == false)
                valid = false;
            if (validatepotvrdaLozinka() == false)
                valid = false;

            if (valid == false)
            {
                return false;
            }
            else
            {
                return true;
            };
        }
        private bool validateIme()
        {
            if (inputIme.Text == "")
            {

                imeError.Text = "Ime obavezno!";
                imeError.IsVisible = true;
                return false;
            }
            else
            {

                imeError.IsVisible = false;
                imeError.Text = "";
                return true;
            }
        }

        private bool validatePrezime()
        {
            if (inputPrezime.Text == "")
            {
                prezimeError.Text = "Prezime obavezno!";
                prezimeError.IsVisible = true;
                return false;
            }
            else
            {

                prezimeError.IsVisible = false;
                prezimeError.Text = "";
                return true;
            }
        }
        private bool validateTelefon()
        {
            if (inputTelefon.Text == "")
            {
                telefonError.Text = "Telefon obavezan!";
                telefonError.IsVisible = true;
                return false;
            }
            else
            {

                telefonError.IsVisible = false;
                telefonError.Text = "";
                return true;
            }
        }
        private bool validateEmail()
        {
            try
            {
                MailAddress mail = new MailAddress(inputEmail.Text);

            }
            catch (Exception)
            {
                emailError.Text = "Email nije u ispravnom formatu!";
                emailError.IsVisible = true;
                return false;
            }

            if (inputEmail.Text == "")
            {

                emailError.Text = "Email obavezan!";
                emailError.IsVisible = true;
                return false;
            }
            else
            {

                emailError.IsVisible = false;
                emailError.Text = "";
                return true;
            }
        }
       
        private bool validateLozinka()
        {
            if (inputPassword.Text == "")
            {

                lozinkaError.Text = "Lozinka obavezna!";
                lozinkaError.IsVisible = true;
                return false;
            }
            if (inputPassword.Text.Count() < 6)
            {

                lozinkaError.Text = "Lozinka treba imati najmanje 6 karaktera!";
                lozinkaError.IsVisible = true;
                return false;
            }
            if (inputPassword.Text == inputKorisnickoIme.Text)
            {

                lozinkaError.Text = "Lozinka i korisnicko moraju biti razliciti!";
                lozinkaError.IsVisible = true;
                return false;
            }
            else
            {

                lozinkaError.IsVisible = false;
                lozinkaError.Text = "";
                return true;
            }
        }
        private bool validatepotvrdaLozinka()
        {
            if (inputPassword.Text != inputPotvrda.Text)
            {

                potvrdalozinkaError.Text = "Loznike se ne podudaraju!";
                potvrdalozinkaError.IsVisible = true;
                return false;
            }
            else
            {
                potvrdalozinkaError.Text = "";
                potvrdalozinkaError.IsVisible = false;
                return true;
            }
        }
    }
}