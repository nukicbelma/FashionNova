using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FashionNova.Model.Models;

namespace FashionNova.WebAPI.Services
{
    public class RecommenderService : IRecommender
    {

        Dictionary<int, List<Ocjene>> proizvodi = new Dictionary<int, List<Ocjene>>();
        private readonly FashionNova.WebAPI.Database.FashionNova_IB170007Context _context;
        private readonly IMapper _mapper;
        public RecommenderService(FashionNova.WebAPI.Database.FashionNova_IB170007Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Artikli> GetSlicneArtikle(int artikalID)
        {
            UcitajProizvode(artikalID);


            List<Ocjene> ocjenePosmatranogProizvoda = new List<Ocjene>();
            List<Database.Ocjene> ocjeneizbaze = _context.Ocjene.Where(x => x.ArtikalId == artikalID).OrderBy(y => y.KlijentId).ToList();
            _mapper.Map(ocjeneizbaze, ocjenePosmatranogProizvoda);



            List<Ocjene> zajednickeOcjene1 = new List<Ocjene>();
            List<Ocjene> zajednickeOcjene2 = new List<Ocjene>();
            List<Artikli> preporuceniProizvodi = new List<Artikli>();

            foreach (var item in proizvodi)
            {
                foreach (Ocjene o in ocjenePosmatranogProizvoda)
                {
                    if (item.Value.Where(x => x.KlijentId == o.KlijentId).Count() > 0)
                    {
                        zajednickeOcjene1.Add(o);
                        zajednickeOcjene2.Add(item.Value.Where(x => x.KlijentId == o.KlijentId).First());
                    }
                }

                double slicnosti = 0;
                slicnosti = GetSlicnost(zajednickeOcjene1, zajednickeOcjene2);


                if (slicnosti > 0.99)
                {
                    Database.Artikli element1 = _context.Artikli
                        .Where(x => x.ArtikalId == item.Key).FirstOrDefault();
                    Artikli element2 = new Artikli();

                    element2.VrstaArtikla = element1.VrstaArtikla.Naziv;
                    element2.Materijal = element1.Materijal.Naziv;
                    element2.Velicina = element1.Velicina.Oznaka;
                    element2.Boja = element1.Boja.Naziv;
                    element2.Cijena = element1.Cijena;
                    element2.ArtikalId = element1.ArtikalId;
                    element2.Naziv = element1.Naziv;
                    element2.Sifra = element1.Sifra;
                    element2.Slika = element1.Slika;


                    preporuceniProizvodi.Add(element2);
                }

                zajednickeOcjene1.Clear();
                zajednickeOcjene2.Clear();
            }

            return preporuceniProizvodi;
        }

        private double GetSlicnost(List<Ocjene> zajednickeOcjene1, List<Ocjene> zajednickeOcjene2)
        {
            if (zajednickeOcjene1.Count != zajednickeOcjene2.Count)
                return 0;

            double brojnik = 0, nazivnik1 = 0, nazivnik2 = 0;

            for (int i = 0; i < zajednickeOcjene1.Count; i++)
            {
                brojnik += zajednickeOcjene1[i].Ocjena * zajednickeOcjene2[i].Ocjena;
                nazivnik1 += zajednickeOcjene1[i].Ocjena * zajednickeOcjene1[i].Ocjena;
                nazivnik2 += zajednickeOcjene2[i].Ocjena * zajednickeOcjene2[i].Ocjena;

            }
            nazivnik1 = Math.Sqrt(nazivnik1);
            nazivnik2 = Math.Sqrt(nazivnik2);
            double nazivnik = nazivnik1 * nazivnik2;
            if (nazivnik == 0)
                return 0;
            return brojnik / nazivnik;
        }

        private void UcitajProizvode(int artikalId)
        {
            List<Database.Artikli> aktivniProizvodi = _context.Artikli
                .Where(x => x.ArtikalId != artikalId).ToList();

            Database.Artikli posmatraniartikal = _context.Artikli.Where(x => x.ArtikalId == artikalId).SingleOrDefault();

            List<Artikli> novalista = new List<Artikli>();
            _mapper.Map(aktivniProizvodi, novalista);



            List<Artikli> listakonacna = new List<Artikli>();
            foreach (var item in novalista)
            {
                if (item.VelicinaId == posmatraniartikal.VelicinaId)
                {
                    listakonacna.Add(item);
                }
            }

            foreach (Artikli a in listakonacna)
            {
                List<Database.Ocjene> novalistaocjena = _context.Ocjene.Where(x => x.ArtikalId == a.ArtikalId).ToList();
                List<Ocjene> ocjene = new List<Ocjene>();
                foreach (var item2 in novalistaocjena)
                {

                    Ocjene novaocjena = new Ocjene();
                    novaocjena.Ocjena = item2.Ocjena;
                    novaocjena.OcjenaId = item2.OcjenaId;
                    novaocjena.ArtikalId = item2.ArtikalId;
                    novaocjena.KlijentId = item2.KlijentId;

                    ocjene.Add(novaocjena);
                }

                if (ocjene.Count > 0)
                    proizvodi.Add(a.ArtikalId, ocjene);
            }
        }
    }
}
