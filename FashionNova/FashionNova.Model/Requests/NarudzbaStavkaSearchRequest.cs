using System;
using System.Collections.Generic;
using System.Text;

namespace FashionNova.Model.Requests
{
    public class NarudzbaStavkaSearchRequest
    {
        public int ArtikliId { get; set; }
        public string DatumOd { get; set; }
        public string DatumDo { get; set; }
    }
}
