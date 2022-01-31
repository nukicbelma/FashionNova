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
    public class NarudzbeService : INarudzbeService
    {
        private readonly FashionNova.WebAPI.Database.FashionNova_IB170007Context _context;
        private readonly IMapper _mapper;

        public NarudzbeService(FashionNova.WebAPI.Database.FashionNova_IB170007Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Narudzba> Get(NarudzbeSearchRequest search)
        {
            var query = _context.Narudzba.AsQueryable();
            if (!string.IsNullOrWhiteSpace(search?.BrojNarudzbe))
            {
                query = query.Where(x => x.BrojNarudzbe.StartsWith(search.BrojNarudzbe));
            }
            if ((!string.IsNullOrWhiteSpace((search?.KlijentId).ToString())) && search?.KlijentId != 0)
            {
                query = query.Where(x => x.KlijentId == search.KlijentId);
            }
            if (!string.IsNullOrWhiteSpace(search?.DatumOD) && !string.IsNullOrWhiteSpace(search?.DatumDO))
            {
                var datumOD = Convert.ToDateTime(search.DatumOD);
                var datumDO = Convert.ToDateTime(search.DatumDO);
                query = query.Where(x => x.DatumNarudzbe>datumOD && x.DatumNarudzbe<datumDO);
            }

            //var list = query.ToList();
            //return _mapper.Map<List<Narudzba>>(list);


            var result = _context.Narudzba.Include(y => y.Korisnik).Include(y=>y.Klijent).ToList();
            List<Narudzba> lista = new List<Narudzba>();

            foreach (var item in result)
            {
                Narudzba nova = new Narudzba();
                nova.NarudzbaId = item.NarudzbaId;
                nova.BrojNarudzbe = item.BrojNarudzbe;
                nova.IznosBezPdv = item.IznosBezPdv;
                nova.IznosSaPdv = item.IznosSaPdv;
                nova.KorisnikId = item.KorisnikId;
                nova.Korisnik = item.Korisnik.Ime+" "+item.Korisnik.Prezime;
                nova.KlijentId = item.KlijentId;
                nova.Klijent = item.Klijent.Ime+" "+item.Klijent.Prezime;
                nova.DatumNarudzbe = item.DatumNarudzbe;

                lista.Add(nova);
            }
            return lista;
        }
        //public FashionNova.Model.Models.Velicina GetById(int id)
        //{
        //    var entity = _context.Velicina.Find(id);
        //    return _mapper.Map<FashionNova.Model.Models.Velicina>(entity);
        //}
        public void Insert(NarudzbeInsertRequest request)
        {

            Database.Narudzba nova = new Database.Narudzba();
            nova.BrojNarudzbe = request.BrojNarudzbe;
            nova.DatumNarudzbe = request.DatumNarudzbe;

            if (request.IznosBezPdv > 0)
            {
                nova.IznosBezPdv = request.IznosBezPdv;
            }
            if (request.IznosSaPdv > 0)
            {
                nova.IznosSaPdv = request.IznosSaPdv;
            }
            nova.KorisnikId = request.KorisnikId;
            nova.KlijentId = request.KlijentId;

            _context.Narudzba.Add(nova);
            _context.SaveChanges();

            foreach (var item in request.stavke)
            {

                Database.NarudzbaStavke stavka = new Database.NarudzbaStavke();
                stavka.NarudzbaId = nova.NarudzbaId;
                stavka.Popust = Convert.ToDecimal(item.Popust);
                stavka.Kolicina = item.Kolicina;
                stavka.Cijena = item.Cijena;
                stavka.ArtikalId = item.ArtikalId;

                _context.NarudzbaStavke.Add(stavka);
                _context.SaveChanges();
            }
             _mapper.Map<Narudzba>(nova);
        }
        public FashionNova.Model.Models.Narudzba Update(int id, NarudzbaUpdateRequest request)
        {
            var entity = _context.Narudzba.Find(id);
            _mapper.Map(request, entity);

            _context.SaveChanges();
            return _mapper.Map<Model.Models.Narudzba>(entity);
        }
    }
}
