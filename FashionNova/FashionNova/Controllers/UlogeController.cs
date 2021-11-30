//using FashionNova.Model.Models;
//using FashionNova.WebAPI.Services;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace FashionNova.WebAPI.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class UlogeController : ControllerBase
//    {
//        private readonly IUlogeService _service;

//        public UlogeController(IUlogeService service)
//        {
//            _service = service;
//        }

//        [HttpGet]
//        public List<Uloge> Get()
//        {
//            return _service.Get();
//        }
//    }
//}
