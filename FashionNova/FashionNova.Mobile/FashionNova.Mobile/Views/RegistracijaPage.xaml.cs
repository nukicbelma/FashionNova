using FashionNova.Mobile.ViewModels;
using FashionNova.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FashionNova.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistracijaPage : ContentPage
    {
        RegistracijaViewModel model = null;
        APIService _serviceklijenti = new APIService("Klijenti");
        public RegistracijaPage()
        {
            InitializeComponent();
            BindingContext = model = new RegistracijaViewModel();

        }
        private async void ButtonRegistracija_Clicked(object sender, EventArgs e)
        {
            bool duploime = false;
            bool dupliemail = false;

            List<Klijenti> lista = await _serviceklijenti.Get<List<Klijenti>>(null);

            foreach (var item in lista)
            {
                if (item.KorisnickoIme.Equals(inputKorisnickoIme.Text) == true)
                {
                    duploime = true;
                }
                if (item.Email.Equals(inputEmail.Text) == true)
                {
                    dupliemail = true;
                }
            }
            //if (validateRegistration() == true)
            {

                if (duploime == true)
                {
                    await DisplayAlert("Greska", "Korisnik sa tim korisnickim imenom je vec registrovan", "OK");
                    korisnickoImeError.Text = "Korisnicko ime vec postoji!";
                    korisnickoImeError.IsVisible = true;
                }
                else if (dupliemail == true)
                {
                    await DisplayAlert("Greska", "Korisnik sa tim emailom je vec registrovan", "OK");
                    emailError.Text = "Email vec postoji!";
                    emailError.IsVisible = true;

                }
                else
                {

                    await model.Registracija();
                }


            }
            // else
            //{
            //    await DisplayAlert("Greska", "Niste dobro unijeli neki od podataka", "OK");

            //}
        }
    }
}