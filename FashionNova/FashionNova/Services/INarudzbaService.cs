using FashionNova.Model.Requests;
using System.Collections.Generic;

namespace FashionNova.WebAPI.Services
{
    public interface INarudzbaService
    {
        List<FashionNova.Model.Models.Narudzba> Get(NarudzbeSearchRequest search);
        //FashionNova.Model.Models.Velicina GetById(int id);

        public void Insert(NarudzbaInsertRequest request);
        //public FashionNova.Model.Models.Velicina Update(int id, BojaUpdateRequest request);
    }
}