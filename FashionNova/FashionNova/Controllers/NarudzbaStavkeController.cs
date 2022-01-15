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
    public class NarudzbaStavkeController : ControllerBase
    {
        private readonly INarudzbaStavkeService _service;
        public NarudzbaStavkeController(INarudzbaStavkeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Models.NarudzbaStavke> Get()
        {
            return _service.Get();
        }

        //[HttpGet("{id}")]
        //public FashionNova.Model.Models.Velicina GetById(int id)
        //{
        //    return _service.GetById(id);
        //}
        //[HttpPost]
        //public void Insert(NarudzbeInsertRequest request)
        //{
        //    _service.Insert(request);
        //}

        ////[HttpPut("{id}")]
        ////public FashionNova.Model.Models.Boja Update(int id, [FromBody] BojaUpdateRequest request)
        ////{
        ////    return _service.Update(id, request);
        ////}
    }
}
