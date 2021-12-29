using System;
using System.Collections.Generic;
using System.Text;

namespace FashionNova.Model.Requests
{
    public class NarudzbeSearchRequest
    {
        public string BrojNarudzbe { get; set; }
        public string DatumOD { get; set; }
        public string DatumDO { get; set; }
    }
}
