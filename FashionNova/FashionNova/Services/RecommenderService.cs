//using AutoMapper;
//using Microsoft.EntityFrameworkCore;
//using FashionNova.WebAPI.Database;
//using FashionNova.WebAPI.Services;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace FashionNova.WebAPI.Service
//{
//    public class RecommenderService : IRecommender
//    {
//        protected readonly FashionNova.WebAPI.Database.IB170007Context _context;
//        protected readonly IMapper _mapper;

//        public RecommenderService(FashionNova.WebAPI.Database.IB170007Context context, IMapper mapper)
//        {
//            _context = context;
//            _mapper = mapper;
//        }

//        Dictionary<int, List<Database.Ocjene>> artikliOcjene = new Dictionary<int, List<Database.Ocjene>>();

//        public List<FashionNova.Model.Models.Artikli> GetSlicneArtikle(int artikalID)
//        {
//            var tmp = LoadSimilar(artikalID);
//            return _mapper.Map<List<FashionNova.Model.Models.Artikli>>(tmp);
//        }

//        private List<Database.Artikli> LoadSimilar(int artikalID)
//        {
//            LoadDifVehicles(artikalID);
//            List<Database.Ocjene> ratingsOfThis = _context.Ocjene.Where(e => e.ArtikalId == artikalID).OrderBy(e => e.KlijentId).ToList();

//            List<Database.Ocjene> ratings1 = new List<Database.Ocjene>();
//            List<Database.Ocjene> ratings2 = new List<Database.Ocjene>();
//            List<Database.Artikli> recommendedVehicles = new List<Database.Artikli>();
            

//            foreach (var item in artikliOcjene)
//            {
//                foreach (Database.Ocjene rating in ratingsOfThis)
//                {
//                    if (item.Value.Where(x => x.KlijentId == rating.KlijentId).Count() > 0)
//                    {
//                        ratings1.Add(rating);
//                        ratings2.Add(item.Value.Where(x => x.KlijentId == rating.KlijentId).First());
//                    }
//                }
//                double similarity = GetSimilarity(ratings1, ratings2);
//                if (similarity > 0.5)
//                {
//                    recommendedVehicles.Add(_context.Artikli.Where(x => x.ArtikalId == item.Key)
//                        //.Include(x => x.VrstaArtikla)
//                        //.Include(x => x.VehicleModel.Manufacturer)
//                        .FirstOrDefault());
//                }
//                ratings1.Clear();
//                ratings2.Clear();
//            }
//            return recommendedVehicles;
//        }

//        private double GetSimilarity(List<Database.Ocjene> ratings1, List<Database.Ocjene> ratings2)
//        {
//            if (ratings1.Count != ratings2.Count)
//            {
//                return 0;
//            }

//            double x = 0, y1 = 0, y2 = 0;
//            for (int i = 0; i < ratings1.Count; i++)
//            {
//                x += ratings1[i].Ocjena * ratings2[i].Ocjena;
//                y1 += ratings1[i].Ocjena * ratings1[i].Ocjena;
//                y2 += ratings2[i].Ocjena * ratings2[i].Ocjena;
//            }
//            y1 = Math.Sqrt(y1);
//            y2 = Math.Sqrt(y2);

//            double y = y1 * y2;
//            if (y == 0)
//                return 0;
//            return x / y;
//        }

//        private void LoadDifVehicles(int vehicleId)
//        {
//            var artikalVelicina = _context.Artikli.Find(vehicleId);
//            List<Database.Artikli> allVehicles = _context.Artikli.Where(e => e.ArtikalId != vehicleId && e.VelicinaId==artikalVelicina.VelicinaId).ToList();
//            List<Database.Ocjene> ratings = new List<Database.Ocjene>();
//            foreach (var item in allVehicles)
//            {
//                ratings = _context.Ocjene.Where(e => e.ArtikalId == item.ArtikalId).OrderBy(e => e.KlijentId).ToList();
//                if (ratings.Count > 0)
//                    artikliOcjene.Add(item.ArtikalId, ratings);
//            }
//        }
//    }
//}

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using FashionNova.WebAPI.Database;
using FashionNova.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionNova.WebAPI.Service
{
    public class RecommenderService : IRecommender
    {
        protected readonly FashionNova.WebAPI.Database.IB170007Context _context;
        protected readonly IMapper _mapper;

        public RecommenderService(FashionNova.WebAPI.Database.IB170007Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        Dictionary<int, List<Database.Ocjene>> artikliOcjene = new Dictionary<int, List<Database.Ocjene>>();

        public List<FashionNova.Model.Models.Artikli> GetSlicneArtikle(int artikalID)
        {
            var ocjene = _context.Ocjene.AsQueryable().ToList();
            var tmp = LoadSimilar(artikalID);

            var konacna= _mapper.Map<List<FashionNova.Model.Models.Artikli>>(tmp);
            //return _mapper.Map<List<FashionNova.Model.Models.Artikli>>(tmp);

            
            foreach(var item in konacna)
            {
                decimal suma = 0; int brojac = 0;
                foreach (var ocj in ocjene)
                {
                    if(item.ArtikalId==ocj.ArtikliId)
                    {
                        brojac++;
                        suma += ocj.Ocjena;
                    }
                }
                suma /= brojac;
                item.prosjecnaOcjena = Math.Round(suma, 2);
            }
            return konacna;
        }

        private List<Database.Artikli> LoadSimilar(int artikalID)
        {
            LoadDifVehicles(artikalID);
            List<Database.Ocjene> ratingsOfThis = _context.Ocjene.Where(e => e.ArtikliId == artikalID).OrderBy(e => e.KlijentiId).ToList();

            List<Database.Ocjene> ratings1 = new List<Database.Ocjene>();
            List<Database.Ocjene> ratings2 = new List<Database.Ocjene>();
            List<Database.Artikli> recommendedVehicles = new List<Database.Artikli>();
            

            foreach (var item in artikliOcjene)
            {
                foreach (Database.Ocjene rating in ratingsOfThis)
                {
                    if (item.Value.Where(x => x.KlijentiId == rating.KlijentiId).Count() > 0)
                    {
                        ratings1.Add(rating);
                        ratings2.Add(item.Value.Where(x => x.KlijentiId == rating.KlijentiId).First());
                    }
                }
                double similarity = GetSimilarity(ratings1, ratings2);
                if (similarity > 0.5)
                {
                    recommendedVehicles.Add(_context.Artikli.Where(x => x.ArtikliId == item.Key)
                        //.Include(x => x.VrstaArtikla)
                        //.Include(x => x.VehicleModel.Manufacturer)
                        .FirstOrDefault());
                }
                ratings1.Clear();
                ratings2.Clear();
            }
            return recommendedVehicles;
        }

        private double GetSimilarity(List<Database.Ocjene> ratings1, List<Database.Ocjene> ratings2)
        {
            if (ratings1.Count != ratings2.Count)
            {
                return 0;
            }

            double x = 0, y1 = 0, y2 = 0;
            for (int i = 0; i < ratings1.Count; i++)
            {
                x += ratings1[i].Ocjena * ratings2[i].Ocjena;
                y1 += ratings1[i].Ocjena * ratings1[i].Ocjena;
                y2 += ratings2[i].Ocjena * ratings2[i].Ocjena;
            }
            y1 = Math.Sqrt(y1);
            y2 = Math.Sqrt(y2);

            double y = y1 * y2;
            if (y == 0)
                return 0;
            return x / y;
        }

        private void LoadDifVehicles(int vehicleId)
        {
            var artikalVelicina = _context.Artikli.Find(vehicleId);
            List<Database.Artikli> allVehicles = _context.Artikli.Where(e => e.ArtikliId != vehicleId && e.VelicinaId==artikalVelicina.VelicinaId).ToList();
            List<Database.Ocjene> ratings = new List<Database.Ocjene>();
            foreach (var item in allVehicles)
            {
                ratings = _context.Ocjene.Where(e => e.ArtikliId == item.ArtikliId).OrderBy(e => e.KlijentiId).ToList();
                if (ratings.Count > 0)
                    artikliOcjene.Add(item.ArtikliId, ratings);
            }
        }
    }
}



