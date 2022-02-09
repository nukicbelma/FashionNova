using System;
using System.Collections.Generic;

namespace FashionNova.WebAPI.Database
{
    public partial class NarudzbaStavke
    {
        public int NarudzbaStavkeId { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal Popust { get; set; }
        public int NarudzbaId { get; set; }
        public int ArtikliId { get; set; }

        public virtual Artikli Artikli { get; set; }
        public virtual Narudzba Narudzba { get; set; }
    }
}
