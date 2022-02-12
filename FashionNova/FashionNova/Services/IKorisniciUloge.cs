using FashionNova.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionNova.WebAPI.Services
{
    public interface IKorisniciUloge
    {
        public List<Model.Models.KorisniciUloge> Get();
        Task<Model.Models.KorisniciUloge> Insert(KorisniciUlogeInsertRequest request);
    }
}
