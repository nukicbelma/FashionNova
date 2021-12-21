﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FashionNova.Model.Models
{
    public class KorisniciUloge
    {
        public int KorisnikUlogaId { get; set; }
        public DateTime? DatumIzmjene { get; set; }
        public int KorisnikId { get; set; }
        public int UlogaId { get; set; }

        public virtual Korisnici Korisnik { get; set; }
        public virtual Uloge Uloga { get; set; }
    }
}