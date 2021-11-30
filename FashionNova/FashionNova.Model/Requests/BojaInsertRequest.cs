using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FashionNova.Model.Requests
{
    public class BojaInsertRequest
    {
    //    [Required(AllowEmptyStrings = false)]
    //    public int Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
    }
}
