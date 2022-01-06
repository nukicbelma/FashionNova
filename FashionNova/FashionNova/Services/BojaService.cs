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
    public class BojaService : IBojaService
    {
        private readonly FashionNova.WebAPI.Database.FashionNova_IB170007Context _context;
        private readonly IMapper _mapper;

        public BojaService(FashionNova.WebAPI.Database.FashionNova_IB170007Context context, IMapper mapper)
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
        public async Task<bool> PostojiLi(BojaInsertRequest search)
        {
            return !await _context.Boja.AnyAsync(i => i.Naziv == search.Naziv);
        }
        public async Task<Model.Models.Boja> Insert(BojaInsertRequest request)
        {
            if (await PostojiLi(request))
            {
                Database.Boja entity = _mapper.Map<Database.Boja>(request);

                await _context.Boja.AddAsync(entity);
                await _context.SaveChangesAsync();
                return _mapper.Map<Model.Models.Boja>(entity);
            }
            else
                throw new UserException($"Boja {request.Naziv} vec postoji!", HttpStatusCode.BadRequest);
        }
        public FashionNova.Model.Models.Boja Update(int id, BojaUpdateRequest request)
        {
            var entity = _context.Boja.Find(id);
            _mapper.Map(request, entity);

            _context.SaveChanges();
            return _mapper.Map<Model.Models.Boja>(entity);
        }
    }
}
