﻿using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using FashionNova.Services;
using FashionNova.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionNova.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class KlijentiController : ControllerBase
    {
        private readonly IKlijentiService _service;

        public KlijentiController(IKlijentiService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Klijenti> Get([FromQuery] KlijentiSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpPost]
        public void Insert(KlijentiInsertRequest request)
        {
            _service.Insert(request);
        }

        //[HttpPut("{id}")]
        //public void Update(int id, [FromBody] KlijentiUpdateRequest request)
        //{
        //    _service.Update(id, request);
        //}
        [HttpGet("{id}")]
        public Klijenti GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}