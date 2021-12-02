using AutoMapper;
using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionNova.WebAPI.Services
{
    public class VelicinaService : IVelicinaService
    {
        private readonly FashionNova.Database.FashionNova_IB170007Context _context;
        private readonly IMapper _mapper;

        public VelicinaService(FashionNova.Database.FashionNova_IB170007Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Velicina> Get(VelicinaSearchRequest search)
        {
            var query = _context.Velicina.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Oznaka))
            {
                query = query.Where(x => x.Oznaka.StartsWith(search.Oznaka));
            }
            var list = query.ToList();
            return _mapper.Map<List<Velicina>>(list);
        }
        public FashionNova.Model.Models.Velicina GetById(int id)
        {
            var entity = _context.Velicina.Find(id);
            return _mapper.Map<FashionNova.Model.Models.Velicina>(entity);
        }
        public void Insert(VelicinaInsertRequest request)
        {
            Database.Velicina entity = _mapper.Map<Database.Velicina>(request);

            _context.Velicina.Add(entity);
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
