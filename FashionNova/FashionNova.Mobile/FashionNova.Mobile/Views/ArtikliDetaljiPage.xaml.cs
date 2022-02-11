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
    public partial class ArtikliDetaljiPage : ContentPage
    {
        ArtikliDetaljiViewModel model = null;
        public ArtikliDetaljiPage(Artikli artikal)
        {
            InitializeComponent();
            BindingContext = model = new ArtikliDetaljiViewModel() { Artikal = artikal };
            
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            await model.Preporuka();
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            
        }
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Artikli;
            await Navigation.PushAsync(new ArtikliDetaljiPage(item));
        }
        private async void ButtonBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}