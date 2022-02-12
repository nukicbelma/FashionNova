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

            CreateMap<Database.Korisnici, Model.Models.Korisnici>().ReverseMap();

            CreateMap<Database.KorisniciUloge, Model.Models.KorisniciUloge>().ReverseMap();
            CreateMap<KorisniciUlogeInsertRequest, Database.KorisniciUloge>().ReverseMap();

            CreateMap<Database.Uloge, Model.Models.Uloge>().ReverseMap();
            CreateMap<Database.Artikli, Model.Models.Artikli>();
            CreateMap<Database.Boja, Model.Models.Boja>();
            CreateMap<Database.Velicina, Model.Models.Velicina>();
            CreateMap<Database.Materijal, Model.Models.Materijal>();
            CreateMap<Database.VrstaArtikla, Model.Models.VrstaArtikla>();
            CreateMap<Database.Klijenti, Model.Models.Klijenti>();
            CreateMap<Database.Narudzba, Model.Models.Narudzba>();
            CreateMap<Database.NarudzbaStavke, Model.Models.NarudzbaStavke>();
            CreateMap<Database.Ocjene, Model.Models.Ocjene>();
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
            CreateMap<KorisniciSearchRequest, Database.Korisnici>().ReverseMap();
            CreateMap<KlijentiSearchRequest, Database.Klijenti>();
            CreateMap<KlijentiInsertRequest, Database.Klijenti>();
            CreateMap<KlijentiUpdateRequest, Database.Klijenti>();
            CreateMap<NarudzbeSearchRequest, Database.Narudzba>();
            CreateMap<NarudzbeInsertRequest, Database.Narudzba>();
            CreateMap<NarudzbaUpdateRequest, Database.Narudzba>();
            CreateMap<NarudzbaStavkaSearchRequest, Database.NarudzbaStavke>();
            CreateMap<OcjeneSearchRequest, Database.Ocjene>();
            CreateMap<OcjenaInsertRequest, Database.Ocjene>();
        }
    }
}
