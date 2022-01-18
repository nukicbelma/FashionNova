using FashionNova.Mobile.Views;
using FashionNova.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FashionNova.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Klijenti");
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());

        }
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }
        async Task Login()
        {
            IsBusy = true;
            try
            {
                Klijenti klijent = await _service.Authenticiraj<Klijenti>(Username, Password);
                if (klijent != null)
                {
                    APIService.Username = Username;
                    APIService.Password = Password;
                   // Global.PrijavljeniKlijent = klijent;
                    await Application.Current.MainPage.DisplayAlert("Uspjeh", "Dobrodosli " + klijent.Ime + " " + klijent.Prezime, "OK");
                    Application.Current.MainPage = new ArtikliPage();
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Greska", "Pogresno unesen username ili password", "OK");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Greska", ex.Message, "OK");
            }
        }
    }
}
