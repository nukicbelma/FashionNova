using FashionNova.Mobile.Models;
using FashionNova.Mobile.Views;
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
    //public partial class MainPage : MasterDetailPage
    //{
    //    public MainPage()
    //    {
    //        InitializeComponent();
    //        MasterPage.ListView.ItemSelected += ListView_ItemSelected;
    //    }

    //    private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    //    {
    //        var item = e.SelectedItem as MainPageMasterMenuItem;
    //        if (item == null)
    //            return;

    //        var page = (Page)Activator.CreateInstance(item.TargetType);
    //        page.Title = item.Title;

    //        Detail = new NavigationPage(page);
    //        IsPresented = false;

    //        MasterPage.ListView.SelectedItem = null;
    //    }
    //}
    public partial class PocetnaPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> listaMeniPage = new Dictionary<int, NavigationPage>();
        public PocetnaPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;
            //listaMeniPage.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!listaMeniPage.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.ONama:
                        listaMeniPage.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.Artikli:
                        listaMeniPage.Add(id, new NavigationPage(new ArtikliPage()));
                        break;
                    case (int)MenuItemType.HistorijaNarudzbi:
                        listaMeniPage.Add(id, new NavigationPage(new HistorijaNarudzbiPage()));
                        break;
                    case (int)MenuItemType.Narudzba:
                        listaMeniPage.Add(id, new NavigationPage(new NarudzbaPage()));
                        break;
                    case (int)MenuItemType.MojProfil:
                        listaMeniPage.Add(id, new NavigationPage(new MojProfilPage()));
                        break;
                    case (int)MenuItemType.LogOut:
                        listaMeniPage.Add(id, new NavigationPage(new MojProfilPage()));
                        break;
                }
            }
            var newPage = listaMeniPage[id];
            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);
                newPage.Title = Title;
                IsPresented = false;
            }
        }
    }
}