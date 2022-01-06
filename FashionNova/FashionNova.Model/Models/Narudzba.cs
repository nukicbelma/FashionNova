using System;
using System.Collections.Generic;
using System.Text;

namespace FashionNova.Model.Models
{
    public class Narudzba
    {
        //public Narudzbe()
        //{
        //    NabavkaStavke = new HashSet<NabavkaStavke>();
        //}
        public int NarudzbaId { get; set; }
        public string BrojNarudzbe { get; set; }
        public DateTime DatumNarudzbe { get; set; }
        public decimal IznosBezPdv { get; set; }
        public decimal IznosSaPdv { get; set; }
        public int KorisnikId { get; set; }

        public virtual Korisnici Korisnik { get; set; }
       // public virtual ICollection<NabavkaStavke> NabavkaStavke { get; set; }
    }
}
