using AutoMapper;
using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionNova.WebAPI.Services
{
    public class BojaService : IBojaService
    {
        private readonly FashionNova.Database.FashionNova_IB170007Context _context;
        private readonly IMapper _mapper;

        public BojaService(FashionNova.Database.FashionNova_IB170007Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Boja> Get(BojaSearchRequest search)
        {
            var query = _context.Boja.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
            }
            var list = query.ToList();
            return _mapper.Map<List<Boja>>(list);
        }
        public FashionNova.Model.Models.Boja GetById(int id)
        {
            var entity = _context.Boja.Find(id);
            return _mapper.Map<FashionNova.Model.Models.Boja>(entity);
        }
        public void Insert(BojaInsertRequest request)
        {
            Database.Boja entity = _mapper.Map<Database.Boja>(request);


            _context.Boja.Add(entity);
            _context.SaveChanges();

        }
    }
}
