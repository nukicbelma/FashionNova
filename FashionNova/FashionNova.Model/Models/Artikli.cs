using System;
using System.Collections.Generic;
using System.Text;

namespace FashionNova.Model.Models
{
    public class Artikli
    {
        public int ArtikalId { get; set; }
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public decimal? Cijena { get; set; }
        public byte[] Slika { get; set; }
        public int BojaId { get; set; }
        public int MaterijalId { get; set; }
        public int VelicinaId { get; set; }
        public int VrstaArtiklaId { get; set; }

        public string Boja { get; set; }
        public string Materijal { get; set; }
        public string Velicina { get; set; }
        public string VrstaArtikla { get; set; }
    }
}
