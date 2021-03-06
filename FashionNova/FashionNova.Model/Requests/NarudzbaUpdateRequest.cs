using System;
using System.Collections.Generic;
using System.Text;

namespace FashionNova.Model.Requests
{
    public class NarudzbaUpdateRequest
    {
        public int NarudzbaId { get; set; }
        public string BrojNarudzbe { get; set; }
        public int KlijentId { get; set; }
        public DateTime Datum { get; set; }
        public decimal IznosBezPdv { get; set; }
        public decimal IznosSaPdv { get; set; }
        public int KorisnikId { get; set; }
    }
}
