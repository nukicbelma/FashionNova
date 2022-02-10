using System;
using System.Collections.Generic;
using System.Text;

namespace FashionNova.Model.Models
{
     public class Ocjene
    {
        public int OcjeneId { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
        public int ArtikliId { get; set; }
        public int KlijentiId { get; set; }
        //public virtual Artikli Artikal { get; set; }
       // public virtual Klijenti Klijent { get; set; }
    }
}
