using FashionNova.Mobile.Services;
using FashionNova.Model.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FashionNova.Mobile.ViewModels
{
    public class HistorijaNarudzbiViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Narudzbe");
        public string KlijentId { get; set; }
        public HistorijaNarudzbiViewModel()
        {
            InitCommand = new Command(async () => await Init());
            KlijentId = PrijavljeniKlijentService.PrijavljeniKlijent.KlijentId.ToString();


        }
        public ObservableCollection<Narudzba> ListaNarudzbi { get; set; } = new ObservableCollection<Narudzba>();
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            List<Narudzba> lista = await _service.Get<List<Narudzba>>(null);
            ListaNarudzbi.Clear();
            foreach (var item in lista)
            {
                if (item.KlijentId == PrijavljeniKlijentService.PrijavljeniKlijent.KlijentId)
                {
                    ListaNarudzbi.Add(item);
                    KlijentId = item.KlijentId.ToString();
                }
            }
        }
    }
}
