using FashionNova.Model.Models;
using System.Collections.Generic;

namespace FashionNova.WebAPI.Services
{
    public interface IRecommender
    {
        List<Artikli> GetSlicneArtikle(int artikalID);
    }
}