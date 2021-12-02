﻿using System;
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

            CreateMap<Database.Korisnici, Model.Korisnici>();
            CreateMap<Database.Uloge, Model.Models.Uloge>();
            CreateMap<Database.Artikli, Model.Models.Artikli>();
            CreateMap<Database.Boja, Model.Models.Boja>();
            CreateMap<Database.Velicina, Model.Models.Velicina>();
            CreateMap<Database.Materijal, Model.Models.Materijal>();
            CreateMap<BojaInsertRequest, Database.Boja>();
            CreateMap<BojaUpdateRequest, Database.Boja>();
            CreateMap<BojaSearchRequest, Database.Boja>();
            CreateMap<VelicinaSearchRequest, Database.Velicina>();
            CreateMap<VelicinaInsertRequest, Database.Velicina>();
            CreateMap<MaterijalSearchRequest, Database.Materijal>();
            CreateMap<MaterijalInsertRequest, Database.Materijal>();
            CreateMap<MaterijalUpdateRequest, Database.Materijal>();
        }
    }
}
