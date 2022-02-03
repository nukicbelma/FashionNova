using System;
using System.Collections.Generic;
using System.Text;

namespace FashionNova.Model.Requests
{
    public class OcjeneSearchRequest
    {
        public int OcjenaId { get; set; }
        public int Ocjena { get; set; }
        public string Komentar { get; set; }
        public int ArtikalId { get; set; }
        public int KlijentId { get; set; }
        public string[] IncludeList { get; set; }
    }
}
