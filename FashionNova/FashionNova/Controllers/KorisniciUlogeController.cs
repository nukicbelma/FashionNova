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
    public class KorisniciUlogeController : ControllerBase
    {
        private readonly IKorisniciUloge _service;
        public KorisniciUlogeController(IKorisniciUloge service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Models.KorisniciUloge> Get()
        {
            return _service.Get();
        }

        [HttpPost]
        public async Task<FashionNova.Model.Models.KorisniciUloge> Insert([FromBody] KorisniciUlogeInsertRequest request)
        {
            return await _service.Insert(request);
        }
    }
}
