using AutoMapper;
using FashionNova.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionNova.WebAPI.Services
{
    public interface IArtikliService
    {
        List<FashionNova.Model.Models.Artikli> Get(ArtikliSearchRequest search);

        FashionNova.Model.Models.Artikli GetById(int id);

        FashionNova.Model.Models.Artikli GetBySifra(string sifra);
        public void Insert(ArtikliInsertRequest request);
        public void Update(int id, ArtikliInsertRequest request);
    }
}
