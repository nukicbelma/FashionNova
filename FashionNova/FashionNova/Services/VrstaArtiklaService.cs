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
using Xceed.Wpf.Toolkit;

namespace FashionNova.WebAPI.Services
{
    public class VrstaArtiklaService : IVrstaArtiklaService
    {
        private readonly FashionNova.WebAPI.Database.IB170007Context _context;
        private readonly IMapper _mapper;

        public VrstaArtiklaService(FashionNova.WebAPI.Database.IB170007Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<VrstaArtikla> GetAll(VrstaArtiklaSearchRequest search)
        {
            var query = _context.VrstaArtikla.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
            }
            var list = query.ToList();
            return _mapper.Map<List<VrstaArtikla>>(list);
        }
        public async Task<bool> PostojiLi(VrstaArtiklaInsertRequest search)
        {
            return !await _context.VrstaArtikla.AnyAsync(i => i.Naziv == search.Naziv);
        }
        public FashionNova.Model.Models.VrstaArtikla GetById(int id)
        {
            var entity = _context.VrstaArtikla.Find(id);
            return _mapper.Map<FashionNova.Model.Models.VrstaArtikla>(entity);
        }
        public  async Task<Model.Models.VrstaArtikla> Insert(VrstaArtiklaInsertRequest request)
        {
            if (await PostojiLi(request))
            {
                Database.VrstaArtikla entity = _mapper.Map<Database.VrstaArtikla>(request);

                await _context.VrstaArtikla.AddAsync(entity);
                await _context.SaveChangesAsync();
                return _mapper.Map<Model.Models.VrstaArtikla>(entity);
            }
            else
                throw new UserException($"Korisničko ime {request.Naziv} je zauzeto!" , HttpStatusCode.BadRequest );           
        }
        public FashionNova.Model.Models.VrstaArtikla Update(int id, VrstaArtiklaUpdateRequest request)
        {
            var entity = _context.VrstaArtikla.Find(id);
            _mapper.Map(request, entity);

            _context.SaveChanges();
            return _mapper.Map<Model.Models.VrstaArtikla>(entity);
        }
    }
}





