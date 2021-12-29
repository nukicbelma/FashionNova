using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FashionNova.Model.Requests;

namespace FashionNova.WebAPI.Mappers
{
    public class FashionNovaProfile : Profile
    {
        public FashionNovaProfile()
        {

            CreateMap<Database.Korisnici, Model.Models.Korisnici>();
            CreateMap<Database.Uloge, Model.Models.Uloge>();
            CreateMap<Database.Artikli, Model.Models.Artikli>();
            CreateMap<Database.Boja, Model.Models.Boja>();
            CreateMap<Database.Velicina, Model.Models.Velicina>();
            CreateMap<Database.Materijal, Model.Models.Materijal>();
            CreateMap<Database.VrstaArtikla, Model.Models.VrstaArtikla>();
            CreateMap<Database.Klijenti, Model.Models.Klijenti>();
            CreateMap<Database.Narudzba, Model.Models.Narudzba>();
            CreateMap<BojaInsertRequest, Database.Boja>();
            CreateMap<BojaUpdateRequest, Database.Boja>();
            CreateMap<BojaSearchRequest, Database.Boja>();
            CreateMap<VelicinaSearchRequest, Database.Velicina>();
            CreateMap<VelicinaInsertRequest, Database.Velicina>();
            CreateMap<MaterijalSearchRequest, Database.Materijal>();
            CreateMap<MaterijalInsertRequest, Database.Materijal>();
            CreateMap<MaterijalUpdateRequest, Database.Materijal>();
            CreateMap<VrstaArtiklaSearchRequest, Database.VrstaArtikla>();
            CreateMap<VrstaArtiklaInsertRequest, Database.VrstaArtikla>();
            CreateMap<VrstaArtiklaUpdateRequest, Database.VrstaArtikla>();
            CreateMap<ArtikliSearchRequest, Database.Artikli>();
            CreateMap<ArtikliUpdateRequest, Database.Artikli>();
            CreateMap<ArtikliDeleteRequest, Database.Artikli>();
            CreateMap<ArtikliInsertRequest, Database.Artikli>();
            CreateMap<KorisniciInsertRequest, Database.Korisnici>();
            CreateMap<KorisniciUpdateRequest, Database.Korisnici>();
            CreateMap<KorisniciSearchRequest, Database.Korisnici>();
            CreateMap<KlijentiSearchRequest, Database.Klijenti>();
            CreateMap<KlijentiInsertRequest, Database.Klijenti>();
            CreateMap<NarudzbeSearchRequest, Database.Narudzba>();
            CreateMap<NarudzbaInsertRequest, Database.Narudzba>();
        }
    }
}
