using FashionNova.Mobile.ViewModels;
using FashionNova.Model.Models;
using FashionNova.Models;
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
    public partial class HistorijaNarudzbiPage : ContentPage
    {
        private HistorijaNarudzbiViewModel model = null;

        public HistorijaNarudzbiPage()
        {
            InitializeComponent();
            BindingContext = model = new HistorijaNarudzbiViewModel();

        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Narudzba;
            await Navigation.PushAsync(new HistorijaNarudzbiDetaljiPage(item));
        }
    }
}