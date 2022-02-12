using AutoMapper;
using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionNova.WebAPI.Services
{
    public class KorisniciUlogeService : IKorisniciUloge
    {
        private readonly FashionNova.WebAPI.Database.IB170007Context _context;
        private readonly IMapper _mapper;

        public KorisniciUlogeService(FashionNova.WebAPI.Database.IB170007Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<KorisniciUloge> Get()
        {
            var query = _context.KorisniciUloge.AsQueryable();
            var list = query.ToList();
            return _mapper.Map<List<KorisniciUloge>>(list);
        }
        public async Task<Model.Models.KorisniciUloge> Insert(KorisniciUlogeInsertRequest request)
        {
                Database.KorisniciUloge entity = _mapper.Map<Database.KorisniciUloge>(request);
                await _context.KorisniciUloge.AddAsync(entity);
                await _context.SaveChangesAsync();
                return _mapper.Map<Model.Models.KorisniciUloge>(entity);
        }
    }
}
