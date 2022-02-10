using FashionNova.Mobile;
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
    public partial class HistorijaNarudzbiDetaljiPage : ContentPage
    {
        private readonly APIService _service = new APIService("PoslanaNarudzba");
        private readonly APIService _serviceArtikli = new APIService("Artikli");

        HistorijaNarudzbiDetaljiViewModel model = null;
        public HistorijaNarudzbiDetaljiPage(Narudzba narudzba)
        {
            InitializeComponent();
            BindingContext = model = new HistorijaNarudzbiDetaljiViewModel
            {
                Narudzba = narudzba
            };
        }
         private async void ButtonBack_Clicked(object sender, EventArgs e)
        {
            // Application.Current.MainPage = new PocetnaPage();
            await Navigation.PopAsync();
            
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as NarudzbaStavke;
            Artikli selected = new Artikli();
            var artikli = await _serviceArtikli.Get<List<Artikli>>(null);
            foreach (var artikal in artikli)
            {
                if (item.ArtikalId == artikal.ArtikliId)
                    selected = artikal;
            }
            await Navigation.PushAsync(new ArtikliDetaljiPage(selected));
        }
    }
}