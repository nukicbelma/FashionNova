using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FashionNova.Mobile.ViewModels
{
    public class RegistracijaViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Klijenti");
        public RegistracijaViewModel()
        {


        }
        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }
        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }
        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
        string _telefon = string.Empty;
        public string Telefon
        {
            get { return _telefon; }
            set { SetProperty(ref _telefon, value); }
        }
        string _korisnickoime = string.Empty;
        public string KorisnickoIme
        {
            get { return _korisnickoime; }
            set { SetProperty(ref _korisnickoime, value); }
        }
        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        string _potvrda = string.Empty;
        public string Potvrda
        {
            get { return _potvrda; }
            set { SetProperty(ref _potvrda, value); }
        }



        public async Task Registracija()
        {
            KlijentiInsertRequest request = new KlijentiInsertRequest();
            
            request.Email = Email;
            request.Ime = Ime;
            request.Prezime = Prezime;
            request.KorisnickoIme = KorisnickoIme;
            request.Telefon = Telefon;
            request.Password = Password;
            request.PasswordPotvrda = Potvrda;

            await _service.Insert<Klijenti>(request);
            await Application.Current.MainPage.Navigation.PopAsync();
            await Application.Current.MainPage.DisplayAlert("Welcome", "Uspjesno ste kreirali novi korisnicki racun. ", "OK");
        }
    }
}
