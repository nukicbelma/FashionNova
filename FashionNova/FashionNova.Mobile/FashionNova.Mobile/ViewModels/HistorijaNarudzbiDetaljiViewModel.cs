using FashionNova.Model.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace FashionNova.Mobile.ViewModels
{
    public class HistorijaNarudzbiDetaljiViewModel
    {
        private readonly APIService _serviceNarudzbe = new APIService("NarudzbaStavke");
        private readonly APIService _serviceArtikli = new APIService("Artikli");
        
        public HistorijaNarudzbiDetaljiViewModel()
        {

        }

        public Narudzba Narudzba { get; set; }
        public ObservableCollection<NarudzbaStavke> listastavki { get; set; } = new ObservableCollection<NarudzbaStavke>();
        public ObservableCollection<Artikli> slikeArtikala { get; set; } = new ObservableCollection<Artikli>();
        public byte[] slika { get; set; } 


        public async Task Init()
        {
            var lista = await _serviceNarudzbe.Get<List<NarudzbaStavke>>(null);
            var slike = await _serviceArtikli.Get<List<Artikli>>(null);
            listastavki.Clear();
            foreach (var item in lista)
            {
                if (item.NarudzbaId == Narudzba.NarudzbaId)
                {
                    listastavki.Add(item);
                }
            }
            
            foreach (var item in listastavki)
            {
                foreach (var artikal in slike)
                {
                    if (item.ArtikalId == artikal.ArtikliId)
                        item.SlikaArtikla = artikal.Slika;
                }
            }
        }
    }
}
