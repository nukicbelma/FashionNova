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
        public void Insert(BojaInsertRequest request);
    }
}
