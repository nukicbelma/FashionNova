using AutoMapper;
using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionNova.WebAPI.Services
{
    public class UlogeService : IUlogeService
    {
        private readonly FashionNova.WebAPI.Database.IB170007Context _context;
        private readonly IMapper _mapper;

        public UlogeService(FashionNova.WebAPI.Database.IB170007Context context, IMapper mapper)
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
                uloga.UlogaId = item.UlogeId;

                result.Add(uloga);
            }
            return result;
        }

        public Uloge ProvjeriAdmin(int UlogaId)
        {
            var lista = _context.Uloge.ToList();
            Uloge result = new Uloge();

            foreach (var item in lista)
            {
                if (item.UlogeId == UlogaId)
                {
                    if (item.Naziv.Contains("Admin"))
                    {
                        result.Naziv = item.Naziv;
                        result.OpisUloge = item.OpisUloge;
                        result.UlogaId = item.UlogeId;

                        return result;
                    }
                }
            }
            return null;
        }
    }
}
