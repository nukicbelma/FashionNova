using System;
using System.Collections.Generic;

namespace FashionNova.WebAPI.Database
{
    public partial class Artikli
    {
        public Artikli()
        {
            NarudzbaStavke = new HashSet<NarudzbaStavke>();
            Ocjene = new HashSet<Ocjene>();
        }

        public int ArtikliId { get; set; }
        public string Sifra { get; set; }
        public string Naziv { get; set; }
        public decimal? Cijena { get; set; }
        public byte[] Slika { get; set; }
        public int BojaId { get; set; }
        public int MaterijalId { get; set; }
        public int VelicinaId { get; set; }
        public int VrstaArtiklaId { get; set; }

        public virtual Boja Boja { get; set; }
        public virtual Materijal Materijal { get; set; }
        public virtual Velicina Velicina { get; set; }
        public virtual VrstaArtikla VrstaArtikla { get; set; }
        public virtual ICollection<NarudzbaStavke> NarudzbaStavke { get; set; }
        public virtual ICollection<Ocjene> Ocjene { get; set; }
    }
}
