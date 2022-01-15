using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionNova.WebAPI.Services
{
    public interface INarudzbaStavkeService
    {
        List<FashionNova.Model.Models.NarudzbaStavke> Get();
        FashionNova.Model.Models.NarudzbaStavke GetById(int id);
    }
}
