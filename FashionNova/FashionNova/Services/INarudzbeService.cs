using FashionNova.Model.Requests;
using System.Collections.Generic;

namespace FashionNova.WebAPI.Services
{
    public interface INarudzbeService
    {
        List<FashionNova.Model.Models.Narudzba> Get(NarudzbeSearchRequest search);
        //FashionNova.Model.Models.Velicina GetById(int id);

        public void Insert(NarudzbeInsertRequest request);
        public FashionNova.Model.Models.Narudzba Update(int id, NarudzbaUpdateRequest request);
    }
}