using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FashionNova.Services
{
    public interface IKorisniciService
    {
        Task<FashionNova.Model.Models.Korisnici> Login(string username, string password);
        List<FashionNova.Model.Models.Korisnici> Get(KorisniciSearchRequest search);
        Korisnici GetById(int id);
        void Insert(KorisniciInsertRequest request);
        void Update(int id, KorisniciUpdateRequest request);
        Korisnici Authenticiraj(string username, string pass);

    }
}