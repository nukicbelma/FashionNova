using System;
using System.Collections.Generic;
using System.Text;

namespace FashionNova.Model.Requests
{
    public class ArtikliSearchRequest
    {
        public string Naziv { get; set; }
        public int VrstaArtiklaId { get; set; }
    }
}
