using Microsoft.EntityFrameworkCore;
using FashionNova.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FashionNova.WebAPI.Services;
using FashionNova.Model.Requests;

namespace FashionNova.WebAPI.Services
{
    public class NarudzbaStavkeService : INarudzbaStavkeService
    {
        private readonly FashionNova.WebAPI.Database.FashionNova_IB170007Context _context;
        public NarudzbaStavkeService(FashionNova.WebAPI.Database.FashionNova_IB170007Context context)
        {
            _context = context;
        }
        public List<NarudzbaStavke> Get()
        {

            var result = _context.NarudzbaStavke.Include(y => y.Artikal).ToList();
            List<NarudzbaStavke> lista = new List<NarudzbaStavke>();
            var artikliList = _context.Artikli.AsQueryable().ToList();

            foreach (var item in result)
            {
                NarudzbaStavke nova = new NarudzbaStavke();
                nova.ArtikalId = item.Artikal.ArtikalId;
                nova.Cijena = item.Cijena;
                nova.Kolicina = item.Kolicina;
                nova.NarudzbaId = item.NarudzbaId;
                nova.NarudzbaStavkeId = item.NarudzbaStavkeId;
                nova.NazivArtikla = item.Artikal.Naziv;
                nova.Popust = item.Popust;
                nova.Sifra = item.Artikal.Sifra;

                foreach (var a in artikliList)
                {
                    if(a.ArtikalId==item.ArtikalId)
                    {
                        nova.VrstaArtiklaId = a.VrstaArtiklaId;
                    }
                }
                lista.Add(nova);
            }

            return lista;
        }
        public NarudzbaStavke GetById(int id)
        {
            var item = _context.NarudzbaStavke.Where(x => x.NarudzbaStavkeId == id).Include(y => y.Artikal).SingleOrDefault();

            NarudzbaStavke nova = new NarudzbaStavke();
            nova.ArtikalId = item.Artikal.ArtikalId;
            nova.Cijena = item.Cijena;
            nova.Kolicina = item.Kolicina;
            nova.NarudzbaId = item.NarudzbaId;
            nova.NarudzbaStavkeId = item.NarudzbaStavkeId;
            nova.NazivArtikla = item.Artikal.Naziv;
            nova.Popust = item.Popust;
            //nova.Sifra = item.Artikal.Sifra;

            return nova;
        }
    }
}
