using System;
using System.Collections.Generic;

namespace FashionNova.WebAPI.Database
{
    public partial class Uloge
    {
        public Uloge()
        {
            KorisniciUloge = new HashSet<KorisniciUloge>();
        }

        public int UlogeId { get; set; }
        public string Naziv { get; set; }
        public string OpisUloge { get; set; }

        public virtual ICollection<KorisniciUloge> KorisniciUloge { get; set; }
    }
}
