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
    public partial class UporediArtiklePage : ContentPage
    {
        private UporediViewModel model = null;
        private Artikli artikal1;
        //private Karakteristike karakteristika1;
        private Artikli artikal2;
        //private Task<Karakteristike> karakteristika2;

        public UporediArtiklePage(Artikli artikal1, Artikli artikal2)
        {
            BindingContext = model = new UporediViewModel
            {
                Artikal1 = artikal1,
                Artikal2 = artikal2,
            };
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        private async void ButtonBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}