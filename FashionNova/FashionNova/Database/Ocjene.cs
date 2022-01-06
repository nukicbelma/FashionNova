using System;
using System.Collections.Generic;

namespace FashionNova.WebAPI.Database
{
    public partial class Ocjene
    {
        public int OcjenaId { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
        public int ArtikalId { get; set; }
        public int KlijentId { get; set; }

        public virtual Artikli Artikal { get; set; }
        public virtual Klijenti Klijent { get; set; }
    }
}
