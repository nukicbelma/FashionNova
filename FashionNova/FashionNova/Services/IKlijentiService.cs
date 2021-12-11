using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FashionNova.Services
{
    public interface IKlijentiService
    {
        List<Klijenti> Get(KlijentiSearchRequest search);

        Klijenti GetById(int id);

        void Insert(KlijentiInsertRequest request);

        //void Update(int id, KlijentiUpdateRequest request);
    }
}