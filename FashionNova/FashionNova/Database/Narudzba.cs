using System;
using System.Collections.Generic;

namespace FashionNova.WebAPI.Database
{
    public partial class Narudzba
    {
        public Narudzba()
        {
            NarudzbaStavke = new HashSet<NarudzbaStavke>();
        }

        public int NarudzbaId { get; set; }
        public string BrojNarudzbe { get; set; }
        public DateTime DatumNarudzbe { get; set; }
        public decimal IznosBezPdv { get; set; }
        public decimal IznosSaPdv { get; set; }
        public int KorisnikId { get; set; }
        public int KlijentId { get; set; }

        public virtual Klijenti Klijent { get; set; }
        public virtual Korisnici Korisnik { get; set; }
        public virtual ICollection<NarudzbaStavke> NarudzbaStavke { get; set; }
    }
}
