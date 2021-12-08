using System;
using System.Collections.Generic;
using System.Text;

namespace FashionNova.Model.Models
{
    public class VrstaArtikla
    {
        public int VrstaArtiklaId { get; set; }
        public string Naziv { get; set; }
        public override string ToString()
        {
            return Naziv;
        }
    }
}
