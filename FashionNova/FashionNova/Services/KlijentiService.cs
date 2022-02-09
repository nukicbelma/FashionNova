using AutoMapper;
using FashionNova.Model;
using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using FashionNova.WebAPI.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FashionNova.Services
{
    public class KlijentiService : IKlijentiService

    {
        private readonly IMapper _mapper;
        private readonly FashionNova.WebAPI.Database.IB170007Context _context;

        public KlijentiService(FashionNova.WebAPI.Database.IB170007Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Klijenti> Get(KlijentiSearchRequest search)
        {
            var query = _context.Klijenti.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Ime.ToLower().StartsWith(search.Ime.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Prezime.ToLower().StartsWith(search.Prezime.ToLower()));
            }

            //if (search?.IsUlogeLoadingEnabled == true)
            //{
            //    query = query.Include(x => x.KorisniciUloge);
            //}

            var list = query.ToList();
            return _mapper.Map<List<Klijenti>>(list);
        }

        public Klijenti GetById(int id)
        {
            var entity = _context.Klijenti.Find(id);

            return _mapper.Map<Klijenti>(entity);

        }
        public void Insert(KlijentiInsertRequest request)
        {
            FashionNova.WebAPI.Database.Klijenti entity = _mapper.Map<FashionNova.WebAPI.Database.Klijenti>(request);

            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.Klijenti.Add(entity);
            _context.SaveChanges();
        }
        public async Task<FashionNova.Model.Models.Klijenti> Login(string username, string password)
        {
            var entity = await _context.Korisnici.Include("KlijentiUloge.Uloge").FirstOrDefaultAsync(x => x.KorisnickoIme == username);

            if (entity == null)
            {
                throw new UserException("Pogresan username ili password");
            }

            var hash = GenerateHash(entity.LozinkaSalt, password);

            if (hash != entity.LozinkaHash)
            {
                throw new UserException("Pogresan username ili password");
            }
            return _mapper.Map<FashionNova.Model.Models.Klijenti>(entity);
        }
        public void Update(int id, KlijentiUpdateRequest request)
        {
            var entity = _context.Klijenti.Where(x => x.KlijentiId == id).FirstOrDefault();
            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordPotvrda)
                {
                    throw new Exception("Passwordi se ne slažu");
                }
                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }
            _context.Klijenti.Attach(entity);
            _context.Klijenti.Update(entity);
            _mapper.Map(request, entity);

            _context.SaveChanges();
        }
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
        public FashionNova.Model.Models.Klijenti Authenticiraj(string username, string pass)
        {
            var user = _context.Klijenti.FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var hashedPass = GenerateHash(user.LozinkaSalt, pass);

                if (hashedPass == user.LozinkaHash)
                {
                    return _mapper.Map<FashionNova.Model.Models.Klijenti>(user);
                }
            }
            return null;
        }
    }
}
