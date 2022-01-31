using FashionNova.Mobile.Services;
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
    public partial class LogoutPage : ContentPage
    {
        public LogoutPage()
        {
            InitializeComponent();
        }
        private async void ButtonBack_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new PocetnaPage();
        }
       private async void ButtonLogout_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Pozdrav", "Ugodan ostatak dana!", "OK");
            PrijavljeniKlijentService.PrijavljeniKlijent = null;
            Application.Current.MainPage = new LoginPage();
        }
    }
}