using FashionNova.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionNova.WebAPI.Services
{
    public interface IOcjeneService
    {
        List<FashionNova.Model.Models.Ocjene> Get(OcjeneSearchRequest search);

        Task<Model.Models.Ocjene> Insert(OcjenaInsertRequest request);
        //public FashionNova.Model.Models.Velicina Update(int id, BojaUpdateRequest request);
    }
}
