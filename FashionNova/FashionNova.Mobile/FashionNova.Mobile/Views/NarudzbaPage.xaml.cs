using FashionNova.Mobile.Services;
using FashionNova.Mobile.ViewModels;
using FashionNova.Model.Models;
using FashionNova.Model.Requests;
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
    public partial class NarudzbaPage : ContentPage
    {
        private decimal PDV = 0.17M;
        private NarudzbaViewModel model = null;
        private APIService _service = new APIService("Narudzba");
        public NarudzbaPage()
        {
            InitializeComponent();
            BindingContext = model = new NarudzbaViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
        }

        private async void Zakljuci_Clicked(object sender, EventArgs e)
        {
            if (model.NarudzbaList.Count == 0)
            {
                await DisplayAlert("Greška", "Nije moguće zaključiti praznu narudžbu.", "OK");
                return;
            }
            List<Narudzba> list = await _service.Get<List<Narudzba>>(null);
            int najveci = int.MinValue;
            foreach (var item in list)
            {
                if (item.NarudzbaId > najveci)
                {
                    najveci = item.NarudzbaId;
                }
            }
            int BrojNarudzbe = najveci + 1;
            string neki = "";// BrojNarudzbeHelper.GenerisiBrojNarudzbe(BrojNarudzbe);

            NarudzbeInsertRequest request = new NarudzbeInsertRequest();
            request.BrojNarudzbe = neki;
            request.Datum = DateTime.Now;
            //request.KlijentId = Global.PrijavljeniKlijent.KlijentId;
            request.KorisnikId = 1;
            foreach (var item in model.NarudzbaList)
            {
                NarudzbaStavkeInsertRequest stavka = new NarudzbaStavkeInsertRequest();
                stavka.ArtikalId = item.Artikal.ArtikalId;
                stavka.Cijena = decimal.Parse(item.Artikal.Cijena.ToString());
                stavka.Kolicina = int.Parse(item.Kolicina.ToString());
                stavka.Popust = 0;
                request.IznosBezPdv += stavka.Cijena * stavka.Kolicina;
                request.IznosSaPdv = request.IznosBezPdv + request.IznosBezPdv * PDV;
                request.stavke.Add(stavka);
            }

            var narudzba = await _service.Insert<Narudzba>(request);

            await DisplayAlert("Uspjeh", "Uspjesno ste napravili novu narudzbu", "OK");
            model.NarudzbaList.Clear();
            CartService.Cart.Clear();
            lblBrojArtikala.Text = "Broj artikala: 0";
            lblIznos.Text = "Iznos: 0 KM";
           // await Navigation.PushAsync(new StripePaymentGatwayPage(model.Iznos, narudzba.NarudzbaId));
        }

        private async void Otkazi_Clicked(object sender, EventArgs e)
        {
            if (model.NarudzbaList.Count == 0)
            {
                await DisplayAlert("Greška", "Nije moguće otkazati praznu narudžbu.", "OK");
                return;
            }
            model.NarudzbaList.Clear();
            CartService.Cart.Clear();
            lblBrojArtikala.Text = "Broj artikala: 0";
            lblIznos.Text = "Iznos: 0 KM";
            await DisplayAlert("Uspjeh", "Narudžba je uspješno otkazana.", "OK");
        }
    }
}