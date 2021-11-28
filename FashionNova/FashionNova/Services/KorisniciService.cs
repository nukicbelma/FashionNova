using AutoMapper;
using FashionNova.Database;
using FashionNova.Model.Requests;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FashionNova.Services
{
    public class KorisniciService : IKorisniciService

    {
        private readonly IMapper _mapper;
        private readonly FashionNova_IB170007Context _context;

        public KorisniciService(FashionNova_IB170007Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Korisnici> Get(KorisniciSearchRequest search)
        {
            var query = _context.Korisnici.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(search.Ime));
            }

            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(search.Prezime));
            }

            //if (search?.IsUlogeLoadingEnabled == true)
            //{
            //    query = query.Include(x => x.KorisniciUloge);
            //}

            var list = query.ToList();

           return _mapper.Map<List<Korisnici>>(list);

        }

        public Korisnici GetById(int id)
        {
            var entity = _context.Korisnici.Find(id);

            return _mapper.Map<Korisnici>(entity);

        }
        public void Insert(KorisniciInsertRequest request)
        {
            FashionNova.Database.Korisnici entity = _mapper.Map<FashionNova.Database.Korisnici>(request);

            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            //entity.LozinkaSalt = GenerateSalt();
            //entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            //_context.Korisnici.Add(entity);
            _context.SaveChanges();

            foreach (var uloga in request.Uloge)
            {
                //FashionNova.Database.KorisniciUloge korisniciUloge = new FashionNova.Database.KorisniciUloge();
                //korisniciUloge.KorisnikId = entity.KorisnikId;
                //korisniciUloge.UlogaId = uloga;
                //korisniciUloge.DatumIzmjene = DateTime.Now;
                //_context.KorisniciUloge.Add(korisniciUloge);
            }
            _context.SaveChanges();
        }

        public void Update(int id, KorisniciInsertRequest request)
        {
            var entity = _context.Korisnici.Where(x => x.KorisnikId == id).FirstOrDefault();
            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordPotvrda)
                {
                    throw new Exception("Passwordi se ne slažu");
                }
               // entity.LozinkaSalt = GenerateSalt();
              //  entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }

            var ulogeKorisnik = _context.KorisniciUloge.Where(x => x.KorisnikId == id).ToList();

            foreach (int item in request.Uloge)
            {
                var uloga = _context.Uloge.Where(x => x.UlogaId == item).FirstOrDefault();

                var imaUlogu = ulogeKorisnik.Where(x => x.KorisnikUlogaId == uloga.UlogaId).FirstOrDefault();

                if (imaUlogu == null)
                {
                    var korisnikUloga = new FashionNova.Database.KorisniciUloge() { KorisnikId = entity.KorisnikId, UlogaId = uloga.UlogaId, DatumIzmjene = DateTime.Now };

                    entity.KorisniciUloge.Add(korisnikUloga);
                }
            }

            _context.Korisnici.Attach(entity);
            _context.Korisnici.Update(entity);
           // _mapper.Map(request, entity);

            _context.SaveChanges();

        } 
    }
}
