using FashionNova.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace FashionNova.Mobile.ViewModels
{
    public class NarudzbaViewModel :BaseViewModel
    {
        public ObservableCollection<ArtikliDetaljiViewModel> NarudzbaList { get; set; } = new ObservableCollection<ArtikliDetaljiViewModel>();

        decimal _brojartikala = 0;

        public decimal BrojArtikala
        {
            get { return _brojartikala; }
            set { SetProperty(ref _brojartikala, value); }
        }
        decimal _iznos = 0;
        public decimal Iznos
        {
            get { return _iznos; }
            set { SetProperty(ref _iznos, value); }
        }
        public void Init()
        {
            foreach (var item in CartService.Cart.Values)
            {
                NarudzbaList.Add(item);
            }
            Iznos = 0;
            foreach (var item in NarudzbaList)
            {
                Iznos += decimal.Parse(item.Kolicina.ToString()) * decimal.Parse(item.Artikal.Cijena.ToString());
            }
            BrojArtikala = NarudzbaList.Count();
            CartService.Cart.Clear();
        }
    }
}
