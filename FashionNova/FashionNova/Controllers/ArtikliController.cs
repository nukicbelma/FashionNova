using FashionNova.Model.Requests;
using FashionNova.WebAPI.Services;
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
    [Authorize]
    public class ArtikliController : ControllerBase
    {
        private readonly IArtikliService _service;
        public ArtikliController(IArtikliService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<FashionNova.Model.Models.Artikli> Get([FromQuery] ArtikliSearchRequest search)
        {
            return _service.Get(search);
        }

        [HttpGet("{id}")]
        public FashionNova.Model.Models.Artikli GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpGet]
        [Route("GetBySifra/{sifra}")]
        public FashionNova.Model.Models.Artikli GetBySifra(string sifra)
        {
            return _service.GetBySifra(sifra);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public void Insert(ArtikliInsertRequest request)
        {
            _service.Insert(request);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin, Uposlenik")]
        public void Update(int id, [FromBody] ArtikliUpdateRequest request)
        {
            _service.Update(id, request);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<bool> Delete(int id)
        {
            return await _service.Delete(id);
        }
    }
}
