using FashionNova.Mobile.Models;
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
    public partial class ListaMeniPage : ContentPage
    {
        PocetnaPage prvaStranica { get => Application.Current.MainPage as PocetnaPage; }
        List<HomeMenuItem> menuItems;
        public ListaMeniPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem{Id=MenuItemType.ONama,Title="O Nama"},
                new HomeMenuItem {Id = MenuItemType.Artikli, Title="Artikli" },
                new HomeMenuItem{Id=MenuItemType.Narudzba,Title="Narudzba"},
                new HomeMenuItem{Id=MenuItemType.MojProfil,Title="Moj profil"},
                new HomeMenuItem{Id=MenuItemType.HistorijaNarudzbi,Title="Historija narudzbi"},
                new HomeMenuItem{Id=MenuItemType.LogOut,Title="Odjavi se"}
            };
            ListViewMenu.ItemsSource = menuItems;
            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await prvaStranica.NavigateFromMenu(id);
            };
        }
    }
}