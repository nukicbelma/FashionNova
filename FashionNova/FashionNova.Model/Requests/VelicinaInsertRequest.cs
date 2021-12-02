using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FashionNova.Model.Requests
{
    public class VelicinaInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Oznaka { get; set; }
    }
}
