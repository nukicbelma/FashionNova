using AutoMapper;
using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionNova.WebAPI.Services
{
    public class VrstaArtiklaService : IVrstaArtiklaService
    {
        private readonly FashionNova.Database.FashionNova_IB170007Context _context;
        private readonly IMapper _mapper;

        public VrstaArtiklaService(FashionNova.Database.FashionNova_IB170007Context context, IMapper mapper)
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
        public FashionNova.Model.Models.VrstaArtikla GetById(int id)
        {
            var entity = _context.VrstaArtikla.Find(id);
            return _mapper.Map<FashionNova.Model.Models.VrstaArtikla>(entity);
        }
        public void Insert(VrstaArtiklaInsertRequest request)
        {
            Database.VrstaArtikla entity = _mapper.Map<Database.VrstaArtikla>(request);

            _context.VrstaArtikla.Add(entity);
            _context.SaveChanges();
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
