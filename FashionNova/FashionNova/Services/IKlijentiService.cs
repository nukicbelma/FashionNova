using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FashionNova.Services
{
    public interface IKlijentiService
    {
        List<Klijenti> Get(KlijentiSearchRequest search);
        FashionNova.Model.Models.Klijenti Authenticiraj(string username, string pass);
        Task<FashionNova.Model.Models.Klijenti> Login(string username, string password);
        Klijenti GetById(int id);

        void Insert(KlijentiInsertRequest request);

        void Update(int id, KlijentiUpdateRequest request);
    }
}