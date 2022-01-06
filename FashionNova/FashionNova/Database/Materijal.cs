using System;
using System.Collections.Generic;

namespace FashionNova.WebAPI.Database
{
    public partial class Materijal
    {
        public Materijal()
        {
            Artikli = new HashSet<Artikli>();
        }

        public int MaterijalId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Artikli> Artikli { get; set; }
    }
}
