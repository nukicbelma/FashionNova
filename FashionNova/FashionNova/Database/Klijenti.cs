using System;
using System.Collections.Generic;

namespace FashionNova.WebAPI.Database
{
    public partial class Klijenti
    {
        public Klijenti()
        {
            Narudzba = new HashSet<Narudzba>();
            Ocjene = new HashSet<Ocjene>();
        }

        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public DateTime DatumRegistracijeRacuna { get; set; }
        public byte[] Slika { get; set; }

        public virtual ICollection<Narudzba> Narudzba { get; set; }
        public virtual ICollection<Ocjene> Ocjene { get; set; }
    }
}
