using System;
using System.Collections.Generic;
using System.Text;

namespace FashionNova.Model.Requests
{
    public class OcjeneSearchRequest
    {
        public int OcjeneId { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
        public int ArtikliId { get; set; }
        public int KlijentiId { get; set; }
        public string[] IncludeList { get; set; }
    }
}
