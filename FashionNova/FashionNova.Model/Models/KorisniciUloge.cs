using System;
using System.Collections.Generic;
using System.Text;

namespace FashionNova.Model.Models
{
    public class KorisniciUloge
    {
        public int KorisniciUlogeId { get; set; }
        public DateTime? DatumIzmjene { get; set; }
        public int KorisniciId { get; set; }
        public int UlogeId { get; set; }

        //public virtual Korisnici Korisnici { get; set; }
        public virtual Uloge Uloge { get; set; }
    }
}
