using System;
using System.Collections.Generic;
using System.Text;

namespace FashionNova.Model.Models
{
    public class Klijenti
    {
        //public Klijenti()
        //{
        //    Ocjene = new HashSet<Ocjene>();
        //}

        public int KlijentiId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public DateTime DatumRegistracijeRacuna { get; set; }
        public byte[] Slika { get; set; }
        //public virtual ICollection<Ocjene> Ocjene { get; set; }
    }
}
