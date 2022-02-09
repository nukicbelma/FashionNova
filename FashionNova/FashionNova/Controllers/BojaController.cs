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
    public class BojaController : ControllerBase
    {
        private readonly IBojaService _service;
        public BojaController(IBojaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Models.Boja> Get([FromQuery] BojaSearchRequest search)
        {
            return _service.Get(search);
        }

        [HttpGet("{id}")]
        public FashionNova.Model.Models.Boja GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<FashionNova.Model.Models.Boja> Insert([FromBody] BojaInsertRequest request)
        {
            return await _service.Insert(request);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public FashionNova.Model.Models.Boja Update(int id, [FromBody] BojaUpdateRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
