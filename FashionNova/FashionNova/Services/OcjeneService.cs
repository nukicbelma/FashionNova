using AutoMapper;
using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using FashionNova.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace FashionNova.WebAPI.Services
{
    public class OcjeneService : IOcjeneService
    {
        private readonly FashionNova.WebAPI.Database.FashionNova_IB170007Context _context;
        private readonly IMapper _mapper;

        public OcjeneService(FashionNova.WebAPI.Database.FashionNova_IB170007Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Ocjene> Get(OcjeneSearchRequest search)
        {
            var query = _context.Ocjene.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Komentar))
            {
                query = query.Where(x => x.Komentar.StartsWith(search.Komentar));
            }
            var list = query.ToList();
            return _mapper.Map<List<Ocjene>>(list);
        }
        public async Task<Model.Models.Ocjene> Insert(OcjenaInsertRequest request)
        {
                Database.Ocjene entity = _mapper.Map<Database.Ocjene>(request);

                await _context.Ocjene.AddAsync(entity);
                await _context.SaveChangesAsync();
                return _mapper.Map<Model.Models.Ocjene>(entity);
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
