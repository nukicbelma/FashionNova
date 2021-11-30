using AutoMapper;
using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionNova.WebAPI.Services
{
    public class ArtikliService : IArtikliService
    {
        private readonly IMapper _mapper;
        private readonly FashionNova.Database.FashionNova_IB170007Context _context;
        public ArtikliService(FashionNova.Database.FashionNova_IB170007Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Artikli> Get(ArtikliSearchRequest search)
        {
            var query = _context.Artikli.Include(y => y.VrstaArtiklaId).Include(z => z.VelicinaId).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
            }
            if ((!string.IsNullOrWhiteSpace((search?.VrstaArtiklaId).ToString())) && search?.VrstaArtiklaId != 0)
            {
                query = query.Where(x => x.VrstaArtiklaId == search.VrstaArtiklaId);
            }

            var list = query.ToList();
            List<Artikli> result = new List<Artikli>();

            foreach (var item in list)
            {

                Artikli nova = new Artikli();

                nova.ArtikalId = item.ArtikalId;
                nova.Cijena = item.Cijena;
                nova.BojaId = item.BojaId;
                nova.MaterijalId = item.MaterijalId;
                nova.Naziv = item.Naziv;
                nova.VelicinaId = item.VelicinaId;
                nova.Sifra = item.Sifra;
                nova.Slika = item.Slika;
                nova.VrstaArtiklaId = item.VrstaArtiklaId;

                result.Add(nova);
            }
            return result;
        }
        public FashionNova.Model.Models.Artikli GetById(int id)
        {
            var entity = _context.Artikli.Find(id);

            return _mapper.Map<FashionNova.Model.Models.Artikli>(entity);
        }
        public FashionNova.Model.Models.Artikli GetBySifra(string sifra)
        {
            var entity = _context.Artikli.Where(x => x.Sifra.Equals(sifra)).FirstOrDefault();

            return _mapper.Map<FashionNova.Model.Models.Artikli>(entity);
        }

    }
}
