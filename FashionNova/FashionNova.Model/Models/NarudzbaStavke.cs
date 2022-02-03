using System;
using System.Collections.Generic;
using System.Text;

namespace FashionNova.Model.Models
{
    public class NarudzbaStavke
    {
        public int NarudzbaStavkeId { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal Popust { get; set; }
        public int NarudzbaId { get; set; }
        public int ArtikalId { get; set; }
        public string Sifra { get; set; }
        public int VrstaArtiklaId { get; set; }
        public string NazivArtikla { get; set; }
        public string Narudzba { get; set; }
        public byte[] SlikaArtikla { get; set; }
    }
}
