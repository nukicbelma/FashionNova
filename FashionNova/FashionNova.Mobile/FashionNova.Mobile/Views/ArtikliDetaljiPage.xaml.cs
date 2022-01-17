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
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (model.Kolicina > 0)
            {
                DisplayAlert("Uspjeh", "Uspjesno ste dodali artikal u korpu!", "OK");
            }

        }
    }
}