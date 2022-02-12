using System;
using System.Collections.Generic;
using System.Text;

namespace FashionNova.Model.Requests
{
    public class KorisniciUlogeInsertRequest
    {
        public int KorisniciUlogeId { get; set; }
        public DateTime? DatumIzmjene { get; set; }
        public int KorisniciId { get; set; }
        public int UlogeId { get; set; }
    }
}
