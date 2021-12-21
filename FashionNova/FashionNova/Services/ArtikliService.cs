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
            var query = _context.Artikli
                                         //.Include(x=>x.Vrsta)
                                         //.Include(x => x.VelicinaId) 
                                         //.Include(x=>x.MaterijalId)
                                         //.Include(x=>x.BojaId)
                                         .AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
            }
            if ((!string.IsNullOrWhiteSpace((search?.VrstaArtiklaId).ToString())) && search?.VrstaArtiklaId != 0)
            {
                query = query.Where(x => x.VrstaArtiklaId == search.VrstaArtiklaId);
            }
            if ((!string.IsNullOrWhiteSpace((search?.BojaId).ToString())) && search?.BojaId != 0)
            {
                query = query.Where(x => x.BojaId == search.BojaId);
            }
            if ((!string.IsNullOrWhiteSpace((search?.VelicinaId).ToString())) && search?.VelicinaId != 0)
            {
                query = query.Where(x => x.VelicinaId == search.VelicinaId);
            }
            var list = query.ToList();
            var bojeList = _context.Boja.AsQueryable().ToList();
            var velicineList = _context.Velicina.AsQueryable().ToList();
            var materijaliList = _context.Materijal.AsQueryable().ToList();
            var vrstaArtiklaList = _context.VrstaArtikla.AsQueryable().ToList();
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
                foreach (var b in bojeList)
                {
                    if (nova.BojaId == b.BojaId)
                        nova.Boja = b.Naziv;
                }
                foreach (var va in vrstaArtiklaList)
                {
                    if (nova.VrstaArtiklaId == va.VrstaArtiklaId)
                        nova.VrstaArtikla = va.Naziv;
                }
                foreach (var m in materijaliList)
                {
                    if (nova.MaterijalId == m.MaterijalId)
                        nova.Materijal = m.Naziv;
                }
                foreach (var v in velicineList)
                {
                    if (nova.VelicinaId == v.VelicinaId)
                        nova.Velicina = v.Oznaka;
                }
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
        public void Insert(ArtikliInsertRequest request)
        {
            Database.Artikli entity = _mapper.Map<Database.Artikli>(request);
            _context.Artikli.Add(entity);
            _context.SaveChanges();
        }
        public void Update(int id, ArtikliUpdateRequest request)
        {
            var entity = _context.Artikli.Find(id);
            _context.Artikli.Attach(entity);
            _context.Artikli.Update(entity);
            _mapper.Map(request, entity);
            _context.SaveChanges();
        }
        public  IEnumerable<FashionNova.Model.Models.Artikli> GetObject(ArtikliSearchRequest search = null)
        {
            var entity = _context.Set<FashionNova.Database.Artikli>().AsQueryable();


            //if (search.BojaId.HasValue)
            //{
            //    entity = entity.Where(x => x.BojaId == search.BojaId);

            //}
            //if (search.VrstaId.HasValue)
            //{
            //    entity = entity.Where(x => x.VrstaId == search.VrstaId);

            //}
            //if (search?.IncludeJedinicaMjere == true)
            //{
            //    entity = entity.Include(x => x.JedinicaMjere);
            //}
            if (search?.IncludeList?.Length > 0)
            {
                foreach (var item in search.IncludeList)
                {
                    entity = entity.Include(item);
                }
            }

            var list = entity.ToList();
            return _mapper.Map<List<FashionNova.Model.Models.Artikli>>(list);
        }

    }
}
