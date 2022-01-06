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
    public class MaterijalController : ControllerBase
    {
        private readonly IMaterijalService _service;
        public MaterijalController(IMaterijalService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<FashionNova.Model.Models.Materijal> GetAll([FromQuery] MaterijalSearchRequest search)
        {
            return _service.GetAll(search);
        }
        [HttpGet("{id}")]
        public FashionNova.Model.Models.Materijal GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public async Task<FashionNova.Model.Models.Materijal> Insert([FromBody] MaterijalInsertRequest request)
        {
            return await _service.Insert(request);
        }

        [HttpPut("{id}")]
        public FashionNova.Model.Models.Materijal Update(int id, [FromBody] MaterijalUpdateRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
