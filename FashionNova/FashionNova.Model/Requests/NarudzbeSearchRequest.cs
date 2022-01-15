using System;
using System.Collections.Generic;
using System.Text;

namespace FashionNova.Model.Requests
{
    public class NarudzbeSearchRequest
    {
        public int NarudzbaId { get; set; }
        public int KlijentId { get; set; }
        public string BrojNarudzbe { get; set; }
        public string DatumOD { get; set; }
        public string DatumDO { get; set; }
    }
}
