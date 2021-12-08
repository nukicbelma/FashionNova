﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FashionNova.Model.Requests;


namespace FashionNova.WebAPI.Services
{
    public interface IVrstaArtiklaService
    {
        List<FashionNova.Model.Models.VrstaArtikla> GetAll(VrstaArtiklaSearchRequest search);
        FashionNova.Model.Models.VrstaArtikla GetById(int id);
        public void Insert(VrstaArtiklaInsertRequest request);
        public FashionNova.Model.Models.VrstaArtikla Update(int id, VrstaArtiklaUpdateRequest request);
    }
}
