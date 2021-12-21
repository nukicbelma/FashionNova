using System;
using System.Collections.Generic;


namespace FashionNova.Model.Models
{
    public partial class Korisnici
    {
        public Korisnici()
        {
            //KorisniciUloge = new HashSet<KorisniciUloge>();
            //Narudzba = new HashSet<Narudzba>();
        }

        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public byte[] Slika { get; set; }

        public virtual ICollection<KorisniciUloge> KorisniciUloge { get; set; }
        //public virtual ICollection<Narudzba> Narudzba { get; set; }
    }
}
