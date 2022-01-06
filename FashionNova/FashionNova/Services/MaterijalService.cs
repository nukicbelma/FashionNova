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
    public class MaterijalService : IMaterijalService
    {
        private readonly FashionNova.WebAPI.Database.FashionNova_IB170007Context _context;
        private readonly IMapper _mapper;

        public MaterijalService(FashionNova.WebAPI.Database.FashionNova_IB170007Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Materijal> GetAll(MaterijalSearchRequest search)
        {
            var query = _context.Materijal.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
            }
            var list = query.ToList();
            return _mapper.Map<List<Materijal>>(list);
        }
        public FashionNova.Model.Models.Materijal GetById(int id)
        {
            var entity = _context.Materijal.Find(id);
            return _mapper.Map<FashionNova.Model.Models.Materijal>(entity);
        }
        public async Task<bool> PostojiLi(MaterijalInsertRequest search)
        {
            return !await _context.Materijal.AnyAsync(i => i.Naziv == search.Naziv);
        }
        public async Task<Model.Models.Materijal> Insert(MaterijalInsertRequest request)
        {
            if (await PostojiLi(request))
            {
                Database.Materijal entity = _mapper.Map<Database.Materijal>(request);

                await _context.Materijal.AddAsync(entity);
                await _context.SaveChangesAsync();
                return _mapper.Map<Model.Models.Materijal>(entity);
            }
            else
                throw new UserException($"Materijal {request.Naziv} vec postoji!", HttpStatusCode.BadRequest);
        }
        public FashionNova.Model.Models.Materijal Update(int id, MaterijalUpdateRequest request)
        {
            var entity = _context.Materijal.Find(id);
            _mapper.Map(request, entity);

            _context.SaveChanges();
            return _mapper.Map<Model.Models.Materijal>(entity);
        }
    }
}
