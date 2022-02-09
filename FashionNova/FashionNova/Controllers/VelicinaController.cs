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
    public class VelicinaController : ControllerBase
    {
        private readonly IVelicinaService _service;
        public VelicinaController(IVelicinaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Models.Velicina> Get([FromQuery] VelicinaSearchRequest search)
        {
            return _service.Get(search);
        }

        [HttpGet("{id}")]
        public FashionNova.Model.Models.Velicina GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<FashionNova.Model.Models.Velicina> Insert([FromBody] VelicinaInsertRequest request)
        {
            return await _service.Insert(request);
        }
    }
}
