using FashionNova.Mobile.Services;
using FashionNova.Mobile.Views;
using FashionNova.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FashionNova.Mobile.ViewModels
{
    public class ArtikliDetaljiViewModel :BaseViewModel
    {
        public ArtikliDetaljiViewModel()
        {
            PovecajKolicinuCommand = new Command(() => Kolicina += 1);
            SmanjiKolicinuCommand = new Command(() => Kolicina -= 1);
            NaruciCommand = new Command(Naruci);
            BackCommand = new Command(Back);
        }

        public Artikli Artikal { get; set; }

        int _kolicina = 0;
        public int Kolicina
        {
            get { return _kolicina; }
            set { SetProperty(ref _kolicina, value); }
        }

        public ICommand PovecajKolicinuCommand { get; set; }
        public ICommand SmanjiKolicinuCommand { get; set; }

        public ICommand NaruciCommand { get; set; }
        public ICommand BackCommand { get; set; }
        private void Back()
        {
            new NavigationPage(new ArtikliPage());
        }
        private void Naruci()
        {
            if (Kolicina > 0)
            {
                if (CartService.Cart.ContainsKey(Artikal.ArtikalId))
                {
                    CartService.Cart.Remove(Artikal.ArtikalId);
                }
                CartService.Cart.Add(Artikal.ArtikalId, this);
                App.Current.MainPage.DisplayAlert("Korpa", "Uspjesno ste dodali artikal u korpu.", "OK");

            }
            else
            {
                App.Current.MainPage.DisplayAlert("Kolicina ne moze biti 0, povecaj kolicinu", "", "OK");
            }

        }     
    }
}
