using System;
using System.Collections.Generic;

namespace FashionNova.WebAPI.Database
{
    public partial class Ocjene
    {
        public int OcjeneId { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
        public int ArtikliId { get; set; }
        public int KlijentiId { get; set; }

        public virtual Artikli Artikli { get; set; }
        public virtual Klijenti Klijenti { get; set; }
    }
}
