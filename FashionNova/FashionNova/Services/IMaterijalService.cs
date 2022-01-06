using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FashionNova.Model.Requests;

namespace FashionNova.WebAPI.Services
{
    public interface IMaterijalService
    {
        List<FashionNova.Model.Models.Materijal> GetAll(MaterijalSearchRequest search);
        FashionNova.Model.Models.Materijal GetById(int id);
        Task<Model.Models.Materijal> Insert(MaterijalInsertRequest request);
        public FashionNova.Model.Models.Materijal Update(int id, MaterijalUpdateRequest request);
    }
}
