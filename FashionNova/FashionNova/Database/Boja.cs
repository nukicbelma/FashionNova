using System;
using System.Collections.Generic;

namespace FashionNova.WebAPI.Database
{
    public partial class Boja
    {
        public Boja()
        {
            Artikli = new HashSet<Artikli>();
        }

        public int BojaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Artikli> Artikli { get; set; }
    }
}
