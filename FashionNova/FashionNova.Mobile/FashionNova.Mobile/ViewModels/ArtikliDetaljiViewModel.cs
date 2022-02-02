using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using FashionNova.Model.Models;
using System.Threading.Tasks;
using FashionNova.Model.Requests;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using FashionNova.Mobile.Views;
using FashionNova.Mobile.Services;

namespace FashionNova.Mobile.ViewModels
{
    public class ArtikliDetaljiViewModel : BaseViewModel
    {
        private readonly APIService _karakteristikeService = new APIService("Karakteristike");

        private readonly APIService _velicinaService = new APIService("Velicina");
        private readonly APIService _bojaService = new APIService("Boja");

        private readonly APIService _artikliService = new APIService("Artikli");
        private readonly APIService _ocjeneService = new APIService("Ocjene");
        private readonly APIService _sistemPreporuke = new APIService("Recommender");
        public ArtikliDetaljiViewModel()
        {
            PovecajKolicinuCommand = new Command(() => Kolicina += 1);
            SmanjiKolicinuCommand = new Command(() => Kolicina -= 1);
            UporediDvaArtiklaCommand = new Command(async () =>
            {
                if (SelectedArtikal == null)
                {
                    await App.Current.MainPage.DisplayAlert("Not Found selected article", "", "OK");
                }
                else
                {
                     await ((App.Current.MainPage as MasterDetailPage).Detail as NavigationPage)
                    .Navigation.PushAsync(new UporediArtiklePage(Artikal,SelectedArtikal));
                }
            });
            //GetArtikle();

            NijeOcijenjeno = true;
            NaruciCommand = new Command(Naruci);
            InitCommand = new Command(async () => await Init());
            OcijeniSa1Command = new Command(async () => await Ocijeni(1));
            OcijeniSa2Command = new Command(async () => await Ocijeni(2));
            OcijeniSa3Command = new Command(async () => await Ocijeni(3));
            OcijeniSa4Command = new Command(async () => await Ocijeni(4));
            OcijeniSa5Command = new Command(async () => await Ocijeni(5));
        }
        private async Task GetArtikle()
        {
            var listaartikala =  await _artikliService.Get<List<Artikli>>(null);            
            if (ArtikliList.Count == 0)
            {
                foreach (var item in listaartikala)
                {
                    ArtikliList.Add(item);
                }
            }
        }
        public async Task Preporuka()
        {
            //preporuceni artikli SAMO FRONTEND
            ////var listaartikala = await _artikliService.Get<List<Artikli>>(null);
            ////foreach (var item in listaartikala)
            ////{
            ////    if (item.VelicinaId == Artikal.VelicinaId)
            ////        SistemPreporukeList.Add(item);
            ////}

            //preporuceni artikli BACKEND
            //var listaPreporuka = await _sistemPreporuke.GetSlicneArtikle<List<Artikli>>(Artikal.ArtikalId);
            //foreach (var item in listaPreporuka)
            //{
            //    SistemPreporukeList.Add(item);
            //}

            SistemPreporukeList.Clear();
            var lista = await _sistemPreporuke.GetSlicneArtikle<List<Artikli>>(Artikal.ArtikalId);
            var listaocjena2 = await _ocjeneService.Get<List<Ocjene>>(null);
            foreach (var item in lista)
            {
                SistemPreporukeList.Add(item);
            }
        }

        public async Task Ocijeni(int ocjena)
        {
            OcjenaInsertRequest x = new OcjenaInsertRequest
            {
                ArtikalId = Artikal.ArtikalId,
                KlijentId = PrijavljeniKlijentService.PrijavljeniKlijent.KlijentId,
                Ocjena = ocjena,
                Datum = DateTime.Now
            };
            await _ocjeneService.Insert<Ocjene>(x);
            Ocijenjeno = true;
            NijeOcijenjeno = false;

            //Nakon insertovanja ocjene, treba izracunati prosjek ocjene za odabrani artikal
            List<Ocjene> listaocjena = new List<Ocjene>();
            listaocjena = await _ocjeneService.Get<List<Ocjene>>(null);
            foreach (var item in listaocjena)
            {
                if (Artikal.ArtikalId == item.ArtikalId)
                {
                    OcjeneArtiklaList.Add(item);
                }
            }
            if (OcjeneArtiklaList.Count() != 0)
            {
                ProsjecnaOcjena = Math.Round(OcjeneArtiklaList.Select(s => s.Ocjena).Average(), 2);
            }
            else
            {
                ProsjecnaOcjena = 0;
            }
            foreach (var item in listaocjena)
            {
                if (Artikal.ArtikalId == item.ArtikalId)
                {
                    Artikal.prosjecnaOcjena = Math.Round(Convert.ToDecimal(ProsjecnaOcjena),2);
                }
            }
            await App.Current.MainPage.DisplayAlert("Hvala Vam!", "Hvala Vam na feedbacku!", "OK");
        }

        public Artikli Artikal { get; set; }
        public ObservableCollection<Artikli> ArtikliList { get; set; } = new ObservableCollection<Artikli>();
        public ObservableCollection<Ocjene> OcjeneArtiklaList { get; set; } = new ObservableCollection<Ocjene>();
        public ObservableCollection<Artikli> SistemPreporukeList { get; set; } = new ObservableCollection<Artikli>();


        public async Task Init()
        {
            await GetArtikle();
            await Preporuka();
        }

        int _kolicina = 0;

        public int Kolicina
        {
            get { return _kolicina; }
            set { SetProperty(ref _kolicina, value); }
        }

        public ICommand PovecajKolicinuCommand { get; set; }
        public ICommand SmanjiKolicinuCommand { get; set; }
        public ICommand UporediDvaArtiklaCommand { get; set; }
        public ICommand OcijeniSa1Command { get; set; }
        public ICommand OcijeniSa2Command { get; set; }
        public ICommand OcijeniSa3Command { get; set; }
        public ICommand OcijeniSa4Command { get; set; }
        public ICommand OcijeniSa5Command { get; set; }
        public ICommand getProsjek { get; set; }


        public ICommand NaruciCommand { get; set; }
        public ICommand InitCommand { get; set; }

        private void Naruci()
        {
            if (Kolicina > 0)
            {
                if (CartService.Cart.ContainsKey(Artikal.ArtikalId))
                {
                    CartService.Cart.Remove(Artikal.ArtikalId);
                }
                CartService.Cart.Add(Artikal.ArtikalId, this);
                App.Current.MainPage.DisplayAlert("Hvala Vam!", "Uspješno ste artikal dodali u korpu.", "OK");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Greška", "Kolicina ne moze biti 0, pokušajte ponovo.", "OK");
            }

        }

        double _ProsjecnaOcjena;
        public double ProsjecnaOcjena
        {
            get { return _ProsjecnaOcjena; }
            set
            {
                SetProperty(ref _ProsjecnaOcjena, value);
            }
        }
        bool _Ocijenjeno;
        public bool Ocijenjeno
        {
            get { return _Ocijenjeno; }
            set
            {
                SetProperty(ref _Ocijenjeno, value);
            }
        }
        bool _NijeOcijenjeno;
        public bool NijeOcijenjeno
        {
            get { return _NijeOcijenjeno; }
            set
            {
                SetProperty(ref _NijeOcijenjeno, value);
            }
        }

        bool _NaStanju_IsVisible;
        public bool NaStanju_IsVisible
        {
            get { return _NaStanju_IsVisible; }
            set
            {
                SetProperty(ref _NaStanju_IsVisible, value);
            }
        }

        bool _NijeNaStanju_IsVisible;
        public bool NijeNaStanju_IsVisible
        {
            get { return _NijeNaStanju_IsVisible; }
            set
            {
                SetProperty(ref _NijeNaStanju_IsVisible, value);

            }
        }
        Artikli _SelectedArtikal = null;
        public Artikli SelectedArtikal
        {
            get { return _SelectedArtikal; }
            set
            {
                SetProperty(ref _SelectedArtikal, value);

                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }

    }
}
