using System;
using System.Collections.Generic;

namespace FashionNova.Database
{
    public partial class NabavkaStavke
    {
        public int NabavkeStavkeId { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal Popust { get; set; }
        public int NarudzbaId { get; set; }
        public int ArtikalId { get; set; }

        public virtual Artikli Artikal { get; set; }
        public virtual Narudzba Narudzba { get; set; }
    }
}
