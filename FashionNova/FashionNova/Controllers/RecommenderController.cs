using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FashionNova.WebAPI.Services;
using FashionNova.Model.Models;

namespace FashionNova.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class RecommenderController : ControllerBase
    {
        private readonly IRecommender _service;

        public RecommenderController(IRecommender service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetSlicneArtikle/{artikalID}")]
        public List<Artikli> GetSlicneArtikle(int artikalID)
        {
            return _service.GetSlicneArtikle(artikalID);
        }
    }
}
