using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using FashionNova.Services;
using FashionNova.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionNova.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class KlijentiController : ControllerBase
    {
        private readonly IKlijentiService _service;

        public KlijentiController(IKlijentiService service)
        {
            _service = service;
        }

        [HttpGet]
        [AllowAnonymous]
        public List<Klijenti> Get([FromQuery] KlijentiSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        [AllowAnonymous]
        public void Insert(KlijentiInsertRequest request)
        {
            _service.Insert(request);
        }

        [HttpPut("{id}")]
        public void Update(int id, [FromBody] KlijentiUpdateRequest request)
        {
            _service.Update(id, request);
        }
        [HttpGet("{id}")]
        public Klijenti GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("Authenticiraj/{username},{password}")]
        public FashionNova.Model.Models.Klijenti Authenticiraj(string username, string password)
        {
            return _service.Authenticiraj(username, password);
        }

    }
}
