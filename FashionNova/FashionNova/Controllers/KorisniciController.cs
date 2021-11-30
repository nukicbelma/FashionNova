//using FashionNova.Database;
//using FashionNova.Model.Requests;
//using FashionNova.Services;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace FashionNova.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class KorisniciController : ControllerBase
//    {
//        private readonly IKorisniciService _service;

//        public KorisniciController(IKorisniciService service)
//        {
//            _service = service;
//        }

//        [HttpGet]
//        public List<Korisnici> Get([FromQuery] KorisniciSearchRequest request)
//        {
//            return _service.Get(request);
//        }
//        [HttpPost]
//        public void Insert(KorisniciInsertRequest request)
//        {
//            _service.Insert(request);
//        }

//        [HttpPut("{id}")]
//        public void Update(int id, [FromBody] KorisniciInsertRequest request)
//        {
//            _service.Update(id, request);
//        }

//        [HttpGet("{id}")]
//        public Korisnici GetById(int id)
//        {
//            return _service.GetById(id);
//        }
//    }
//}
