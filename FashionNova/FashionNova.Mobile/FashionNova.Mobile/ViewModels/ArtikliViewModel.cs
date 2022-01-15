using FashionNova.Mobile;
using FashionNova.Mobile.Services;
using FashionNova.Mobile.ViewModels;
using FashionNova.Model;
using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FashionNova.Mobile.ViewModels
{
    public class ArtikliViewModel : BaseViewModel
    {
        private readonly APIService _artikliService = new APIService("Artikli");
        private readonly APIService _vrstaArtiklaService = new APIService("VrstaArtikla");


        public ArtikliViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<Artikli> ArtikliList { get; set; } = new ObservableCollection<Artikli>();
        public ObservableCollection<VrstaArtikla> VrstaArtiklaList { get; set; } = new ObservableCollection<VrstaArtikla>();
        VrstaArtikla _selectedVrstaArtikla = null;

        public VrstaArtikla SelectedVrstaArtikla
        {
            get { return _selectedVrstaArtikla; }
            set
            {
                SetProperty(ref _selectedVrstaArtikla, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if (VrstaArtiklaList.Count == 0)
            {
                var vrstaArtiklaList = await _vrstaArtiklaService.Get<List<VrstaArtikla>>(null);

                foreach (var vrstaArtikla in vrstaArtiklaList)
                {
                    VrstaArtiklaList.Add(vrstaArtikla);
                }
            }
            if (SelectedVrstaArtikla != null)
            {
                ArtikliSearchRequest searchRequest = new ArtikliSearchRequest();
                searchRequest.VrstaArtiklaId = SelectedVrstaArtikla.VrstaArtiklaId;

                var list = await _artikliService.Get<IList<Artikli>>(searchRequest);
                ArtikliList.Clear();
                foreach (var item in list)
                {
                    ArtikliList.Add(item);
                }
            }

        }

    }
}
