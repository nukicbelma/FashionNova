using System;
using System.Collections.Generic;
using System.Text;

namespace FashionNova.Mobile.Models
{
    public enum MenuItemType
    {
        Browse,
        Kontakt,
        Artikli,
        Narudzba,
        Obavijesti,
        Zahtjevi,
        HistorijaZahtjeva,
        HistorijaNarudzbi, 
        ONama, 
        MojProfil, 
        LogOut
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
