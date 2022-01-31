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
    public class NarudzbeController : ControllerBase
    {
        private readonly INarudzbeService _service;
        public NarudzbeController(INarudzbeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Models.Narudzba> Get([FromQuery] NarudzbeSearchRequest search)
        {
            return _service.Get(search);
        }

        //[HttpGet("{id}")]
        //public FashionNova.Model.Models.Velicina GetById(int id)
        //{
        //    return _service.GetById(id);
        //}
        [HttpPost]
        public void Insert(NarudzbeInsertRequest request)
        {
            _service.Insert(request);
        }

        [HttpPut("{id}")]
        public FashionNova.Model.Models.Narudzba Update(int id, [FromBody] NarudzbaUpdateRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
