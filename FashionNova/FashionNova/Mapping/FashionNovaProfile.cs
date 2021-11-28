using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace FashionNova.WebAPI.Mappers
{
    public class FashionNovaProfile : Profile
    {
        public FashionNovaProfile()
        {
            CreateMap<Database.Korisnici, Model.Korisnici>();
        }
    }
}
