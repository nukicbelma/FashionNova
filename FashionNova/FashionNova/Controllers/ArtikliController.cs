using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionNova.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ArtikliController :ControllerBase
    {

    }
}
