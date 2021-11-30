using AutoMapper;
using FashionNova.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionNova.WebAPI.Services
{
    public class UlogeService : IUlogeService
    {
        private readonly FashionNova.Database.FashionNova_IB170007Context _context;
        private readonly IMapper _mapper;

        public UlogeService(FashionNova.Database.FashionNova_IB170007Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Uloge> Get()
        {
            List<Uloge> result = new List<Uloge>();
            var lista = _context.Uloge.ToList();

            foreach (var item in lista)
            {
                Uloge uloga = new Uloge();
                uloga.Naziv = item.Naziv;
                uloga.OpisUloge = item.OpisUloge;
                uloga.UlogaId = item.UlogaId;

                result.Add(uloga);
            }
            return result;
        }
    }
}
