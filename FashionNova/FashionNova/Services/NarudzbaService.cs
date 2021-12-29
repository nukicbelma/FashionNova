using AutoMapper;
using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionNova.WebAPI.Services
{
    public class NarudzbaService : INarudzbaService
    {
        private readonly FashionNova.Database.FashionNova_IB170007Context _context;
        private readonly IMapper _mapper;

        public NarudzbaService(FashionNova.Database.FashionNova_IB170007Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Narudzba> Get(NarudzbeSearchRequest search)
        {
            var query = _context.Narudzba.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.BrojNarudzbe))
            {
                query = query.Where(x => x.BrojNarudzbe.StartsWith(search.BrojNarudzbe));
            }
            if (!string.IsNullOrWhiteSpace(search?.DatumOD) && !string.IsNullOrWhiteSpace(search?.DatumDO))
            {
                var datumOD = Convert.ToDateTime(search.DatumOD);
                var datumDO = Convert.ToDateTime(search.DatumDO);
                query = query.Where(x => x.DatumNarudzbe>datumOD && x.DatumNarudzbe<datumDO);
            }
            var list = query.ToList();
            return _mapper.Map<List<Narudzba>>(list);
        }
        //public FashionNova.Model.Models.Velicina GetById(int id)
        //{
        //    var entity = _context.Velicina.Find(id);
        //    return _mapper.Map<FashionNova.Model.Models.Velicina>(entity);
        //}
        public void Insert(NarudzbaInsertRequest request)
        {
            Database.Narudzba entity = _mapper.Map<Database.Narudzba>(request);
            entity.BrojNarudzbe = request.NarudzbaId.ToString();

            var korisnici = _context.Korisnici.AsQueryable().ToList();
            foreach (var k in korisnici)
            {
                if(k.KorisnikId==entity.KorisnikId)
                {
                    
                }
            }

            _context.Narudzba.Add(entity);
            _context.SaveChanges();
        }
        //public FashionNova.Model.Models.Velicina Update(int id, BojaUpdateRequest request)
        //{
        //    var entity = _context.Boja.Find(id);
        //    _mapper.Map(request, entity);

        //    _context.SaveChanges();
        //    return _mapper.Map<Model.Models.Boja>(entity);
        //}
    }
}
