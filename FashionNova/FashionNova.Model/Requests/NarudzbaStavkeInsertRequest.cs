using System;
using System.Collections.Generic;
using System.Text;

namespace FashionNova.Model.Requests
{
    public class NarudzbaStavkeInsertRequest
    {
        public int NarudzbaId { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal? Popust { get; set; }
        public int ArtikalId { get; set; }
    }
}
