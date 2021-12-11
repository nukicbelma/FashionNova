using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FashionNova.Services
{
    public interface IKorisniciService
    {
        List<Korisnici> Get(KorisniciSearchRequest search);

        Korisnici GetById(int id);

        void Insert(KorisniciInsertRequest request);

        void Update(int id, KorisniciUpdateRequest request);
    }
}