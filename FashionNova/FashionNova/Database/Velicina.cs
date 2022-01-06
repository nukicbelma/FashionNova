using System;
using System.Collections.Generic;

namespace FashionNova.WebAPI.Database
{
    public partial class Velicina
    {
        public Velicina()
        {
            Artikli = new HashSet<Artikli>();
        }

        public int VelicinaId { get; set; }
        public string Oznaka { get; set; }

        public virtual ICollection<Artikli> Artikli { get; set; }
    }
}
