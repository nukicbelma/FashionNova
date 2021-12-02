using FashionNova.Model.Requests;
using System.Collections.Generic;

namespace FashionNova.WebAPI.Services
{
    public interface IVelicinaService
    {
        List<FashionNova.Model.Models.Velicina> Get(VelicinaSearchRequest search);
        FashionNova.Model.Models.Velicina GetById(int id);

        public void Insert(VelicinaInsertRequest request);
        //public FashionNova.Model.Models.Velicina Update(int id, BojaUpdateRequest request);
    }
}