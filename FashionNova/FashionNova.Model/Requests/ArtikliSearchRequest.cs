using System;
using System.Collections.Generic;
using System.Text;

namespace FashionNova.Model.Requests
{
    public class ArtikliSearchRequest
    {
        public string Naziv { get; set; }
        public int VrstaArtiklaId { get; set; }
        public int MaterijalId { get; set; }
        public int VelicinaId { get; set; }
        public int BojaId { get; set; }
        public string[] IncludeList { get; set; }
    }
}
