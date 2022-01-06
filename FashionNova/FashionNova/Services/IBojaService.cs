using FashionNova.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionNova.WebAPI.Services
{
    public interface IBojaService
    {
        List<FashionNova.Model.Models.Boja> Get(BojaSearchRequest search);

        FashionNova.Model.Models.Boja GetById(int id);
        Task<Model.Models.Boja> Insert(BojaInsertRequest request);
        public FashionNova.Model.Models.Boja Update(int id,BojaUpdateRequest request);
    }
}
