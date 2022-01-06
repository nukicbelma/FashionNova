using System;
using System.Collections.Generic;

namespace FashionNova.WebAPI.Database
{
    public partial class VrstaArtikla
    {
        public VrstaArtikla()
        {
            Artikli = new HashSet<Artikli>();
        }

        public int VrstaArtiklaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Artikli> Artikli { get; set; }
    }
}
