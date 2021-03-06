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
    public class VrstaArtiklaController : ControllerBase
    {
        private readonly IVrstaArtiklaService _service;
        public VrstaArtiklaController(IVrstaArtiklaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Models.VrstaArtikla> GetAll([FromQuery] VrstaArtiklaSearchRequest search)
        {
            return _service.GetAll(search);
        }

        [HttpGet("{id}")]
        public FashionNova.Model.Models.VrstaArtikla GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<FashionNova.Model.Models.VrstaArtikla> Insert([FromBody]VrstaArtiklaInsertRequest request)
        {
            return await _service.Insert(request);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public FashionNova.Model.Models.VrstaArtikla Update(int id, [FromBody] VrstaArtiklaUpdateRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
