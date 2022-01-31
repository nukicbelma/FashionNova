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
    public class OcjeneController : ControllerBase
    {
        private readonly IOcjeneService _service;
        public OcjeneController(IOcjeneService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Models.Ocjene> Get([FromQuery] OcjeneSearchRequest search)
        {
            return _service.Get(search);
        }

        [HttpPost]
        public async Task<FashionNova.Model.Models.Ocjene> Insert([FromBody] OcjenaInsertRequest request)
        {
            return await _service.Insert(request);
        }

        //[HttpPut("{id}")]
        //public FashionNova.Model.Models.Boja Update(int id, [FromBody] BojaUpdateRequest request)
        //{
        //    return _service.Update(id, request);
        //}
    }
}
