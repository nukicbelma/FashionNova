using FashionNova.Model;
using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using FashionNova.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionNova.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[Authorize]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;

        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("Authenticiraj/{username},{password}")]
        public Korisnici Authenticiraj(string username, string password)
        {
            return _service.Authenticiraj(username, password);
        }

        [HttpGet]
        public IList<FashionNova.Model.Models.Korisnici> Get([FromQuery] KorisniciSearchRequest request)
        {
            return _service.Get(request);
        }

        //[Authorize(Roles = "Admin")]
        [HttpPost]
        public void Insert(KorisniciInsertRequest request)
        {
            _service.Insert(request);
        }

        //[Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public void Update(int id, [FromBody] KorisniciUpdateRequest request)
        {
            _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Korisnici GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
