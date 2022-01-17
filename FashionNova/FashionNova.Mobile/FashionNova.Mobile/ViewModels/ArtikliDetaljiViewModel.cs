using FashionNova.Mobile.Services;
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
        }

        public Artikli Artikal { get; set; }

        decimal _kolicina = 0;
        public decimal Kolicina
        {
            get { return _kolicina; }
            set { SetProperty(ref _kolicina, value); }
        }

        public ICommand PovecajKolicinuCommand { get; set; }
        public ICommand SmanjiKolicinuCommand { get; set; }

        public ICommand NaruciCommand { get; set; }

        private void Naruci()
        {
            if (CartService.Cart.ContainsKey(Artikal.ArtikalId))
            {
                CartService.Cart.Remove(Artikal.ArtikalId);
            }
            CartService.Cart.Add(Artikal.ArtikalId, this);
        }
    }
}
