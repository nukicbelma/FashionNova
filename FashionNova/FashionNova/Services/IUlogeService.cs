using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionNova.WebAPI.Services
{
    public interface IUlogeService
    {
        List<Uloge> Get();
    }
}
