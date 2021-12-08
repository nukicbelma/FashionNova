using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FashionNova.Model.Requests
{
    public class OcjenaInsertRequest
    {
        [Required]
        public int ArtikalId { get; set; }
        [Required]
        public int KlijentId { get; set; }
        [Required]
        public DateTime Datum { get; set; }
        [Required]
        public int Ocjena { get; set; }
    }
}
