using Microsoft.EntityFrameworkCore;
using FashionNova.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FashionNova.Services;
using FashionNova.WebAPI.Database;
using System.IO;

namespace FashionNova.WebAPI.DB
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<string> Salt = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Salt.Add(KorisniciService.GenerateSalt());
            }

            for (int i = 0; i < 5; i++)
            {
                Salt.Add(KlijentiService.GenerateSalt());
            }

            #region Dodavanje uloga
            modelBuilder.Entity<Uloge>().HasData(
                new Uloge()
                {
                    UlogeId = 1,
                    Naziv = "Admin",
                    OpisUloge = "Upravljanje sistemom"
                },
                new Uloge()
                {
                    UlogeId = 2,
                    Naziv = "Uposlenik",
                    OpisUloge = "Rad na sistemu"
                });
            #endregion


            #region Dodavanje vrsta artikla
            modelBuilder.Entity<VrstaArtikla>().HasData(
                new VrstaArtikla()
                {
                    VrstaArtiklaId = 1,
                    Naziv = "Majice",

                },
                 new VrstaArtikla()
                 {
                     VrstaArtiklaId = 2,
                     Naziv = "Farmerke",
                 },
                  new VrstaArtikla()
                  {
                      VrstaArtiklaId = 3,
                      Naziv = "Jakne",
                  },
                  new VrstaArtikla()
                  {
                      VrstaArtiklaId = 4,
                      Naziv = "Suknje",
                  },
                  new VrstaArtikla()
                  {
                      VrstaArtiklaId = 5,
                      Naziv = "Dukserice",
                  }, new VrstaArtikla()
                  {
                      VrstaArtiklaId = 6,
                      Naziv = "Haljine",
                  }, new VrstaArtikla()
                  {
                      VrstaArtiklaId = 7,
                      Naziv = "Trenerke",
                  }, new VrstaArtikla()
                  {
                      VrstaArtiklaId = 1006,
                      Naziv = "Pidzame",
                  });
            #endregion
            #region Dodavanje materijala
            modelBuilder.Entity<Materijal>().HasData(
                new Materijal()
                {
                    MaterijalId = 1,
                    Naziv = "Pamuk",

                },
                 new Materijal()
                 {
                     MaterijalId = 2,
                     Naziv = "Poliester",
                 },
                  new Materijal()
                  {
                      MaterijalId = 3,
                      Naziv = "Jeans",
                  },
                  new Materijal()
                  {
                      MaterijalId = 4,
                      Naziv = "Velur",
                  },
                  new Materijal()
                  {
                      MaterijalId = 5,
                      Naziv = "Koža",
                  }, new Materijal()
                  {
                      MaterijalId = 6,
                      Naziv = "Svila",
                  }, new Materijal()
                  {
                      MaterijalId = 7,
                      Naziv = "Saten",
                  }, new Materijal()
                  {
                      MaterijalId = 1006,
                      Naziv = "Vuna",
                  });
            #endregion
            #region Dodavanje velicina
            modelBuilder.Entity<Velicina>().HasData(
                new Velicina()
                {
                    VelicinaId = 1,
                    Oznaka = "XXS",

                },
                 new Velicina()
                 {
                     VelicinaId = 2,
                     Oznaka = "XS",
                 },
                  new Velicina()
                  {
                      VelicinaId = 3,
                      Oznaka = "S",
                  },
                  new Velicina()
                  {
                      VelicinaId = 4,
                      Oznaka = "M",
                  },
                  new Velicina()
                  {
                      VelicinaId = 5,
                      Oznaka = "L",
                  }, new Velicina()
                  {
                      VelicinaId = 6,
                      Oznaka = "XL",
                  }, new Velicina()
                  {
                      VelicinaId = 7,
                      Oznaka = "XXL",
                  }, new Velicina()
                  {
                      VelicinaId = 8,
                      Oznaka = "XXXL",
                  });
            #endregion

            #region Dodavanje boja
            modelBuilder.Entity<Boja>().HasData(
                new Boja()
                {
                    BojaId = 1,
                    Naziv = "Crvena",

                },
                 new Boja()
                 {
                     BojaId = 2,
                     Naziv = "Narandzasta",
                 },
                  new Boja()
                  {
                      BojaId = 3,
                      Naziv = "Zuta",
                  },
                  new Boja()
                  {
                      BojaId = 4,
                      Naziv = "Plava",
                  },
                  new Boja()
                  {
                      BojaId = 5,
                      Naziv = "Zelena",
                  }, new Boja()
                  {
                      BojaId = 6,
                      Naziv = "Ljubicasta",
                  }, new Boja()
                  {
                      BojaId = 7,
                      Naziv = "Smedja",
                  }, new Boja()
                  {
                      BojaId = 8,
                      Naziv = "Crna",
                  }, new Boja()
                  {
                      BojaId = 9,
                      Naziv = "Siva",
                  }, new Boja()
                  {
                      BojaId = 10,
                      Naziv = "Tamnoplava",
                  }, new Boja()
                  {
                      BojaId = 11,
                      Naziv = "Lila",
                  }, new Boja()
                  {
                      BojaId = 12,
                      Naziv = "Bordo",
                  });
            #endregion
            #region Dodavanje artikala
            modelBuilder.Entity<Artikli>().HasData(
                new Artikli()
                {
                    ArtikliId = 12,
                    Naziv = "Trenerka 'BeFit'",
                    Sifra = "AA00",
                    Cijena = (decimal?)39.00,
                    Slika = File.ReadAllBytes("trenerka1.jpg"),
                    BojaId = 2,
                    MaterijalId = 1,
                    VelicinaId = 4,
                    VrstaArtiklaId = 7
                },

               new Artikli()
               {
                   ArtikliId = 15,
                   Naziv = "Trenerka 'BeFit'",
                   Sifra = "AA00",
                   Cijena = (decimal?)39.00,
                   Slika = File.ReadAllBytes("trenerka3.jpg"),
                   BojaId = 7,
                   MaterijalId = 1,
                   VelicinaId = 5,
                   VrstaArtiklaId = 7
               },
                
                  new Artikli()
                  {
                      ArtikliId = 16,
                      Naziv = "Haljina 'La Perla'",
                      Sifra = "AA11",
                      Cijena = (decimal?)89.90,
                      Slika = File.ReadAllBytes("haljinasmedja1.jpg"),
                      BojaId = 7,
                      MaterijalId = 7,
                      VelicinaId = 3,
                      VrstaArtiklaId = 6
                  },
                    new Artikli()
                    {
                        ArtikliId = 18,
                        Naziv = "Farmerke 'BeTrendy'",
                        Sifra = "AA22",
                        Cijena = (decimal?)49.00,
                        Slika = File.ReadAllBytes("jeans22.jpg"),
                        BojaId = 4,
                        MaterijalId = 3,
                        VelicinaId = 6,
                        VrstaArtiklaId = 2
                    }, new Artikli()
                    {
                        ArtikliId
                        = 2012,
                        Naziv = "Majica 'trendy'",
                        Sifra = "CC11",
                        Cijena = (decimal?)19.90,
                        Slika = File.ReadAllBytes("majicacrvena22.jpg"),
                        BojaId = 1,
                        MaterijalId = 1,
                        VelicinaId = 1,
                        VrstaArtiklaId = 1
                    },
                      new Artikli()
                      {
                          ArtikliId = 2013,
                          Naziv = "Jakna 'Merci'",
                          Sifra = "DD43",
                          Cijena = (decimal?)89.90,
                          Slika = File.ReadAllBytes("crnajakna1.jpg"),
                          BojaId = 8,
                          MaterijalId = 4,
                          VelicinaId = 1,
                          VrstaArtiklaId = 3
                      }, new Artikli()
                      {
                          ArtikliId = 3012,
                          Naziv = "Hlace mom",
                          Sifra = "DD55",
                          Cijena = (decimal?)48.80,
                          Slika = File.ReadAllBytes("jeans12.jpg"),
                          BojaId = 4,
                          MaterijalId = 3,
                          VelicinaId = 1,
                          VrstaArtiklaId = 2
                      }, new Artikli()
                      {
                          ArtikliId
                          = 4012,
                          Naziv = "Majica red4fun",
                          Sifra = "DT15",
                          Cijena = (decimal?)9.90,
                          Slika = File.ReadAllBytes("majicacrvena22.jpg"),
                          BojaId = 1,
                          MaterijalId = 1,
                          VelicinaId = 1,
                          VrstaArtiklaId = 1
                      });
            #endregion

            #region Dodavanje klijenata
            modelBuilder.Entity<Klijenti>().HasData(
                new Klijenti()
                {
                    KlijentiId = 6002,
                    Ime = "Belma",
                    Prezime = "Nukic",
                    DatumRegistracijeRacuna = DateTime.Now,
                    Email = "belma@hotmail.com",
                    Telefon = "123456789",
                    KorisnickoIme = "klijent",
                    Slika = File.ReadAllBytes("profilna1.jpg"),
                    LozinkaSalt = Salt[0],
                    LozinkaHash = KlijentiService.GenerateHash(Salt[0], "klijent44")
                });
            #endregion

            #region Dodavanje korisnika
            modelBuilder.Entity<Korisnici>().HasData(
                new Korisnici()
                {
                    KorisniciId = 2002,
                    Ime = "hanna",
                    Prezime = "hanna",
                    Email = "hanna@example.com",
                    Telefon = "123",
                    KorisnickoIme = "hanna",
                    LozinkaSalt = Salt[0],
                    Slika = File.ReadAllBytes("profilna1.jpg"),
                    LozinkaHash = KlijentiService.GenerateHash(Salt[0], "hanna"), 
                    
                },
                new Korisnici()
                {
                    KorisniciId = 3002,
                    Ime = "Admin",
                    Prezime = "Admin",
                    Email = "admin@gmail.com",
                    Telefon = "063222111",
                    KorisnickoIme = "admin",
                    LozinkaSalt = Salt[1],
                    LozinkaHash = KlijentiService.GenerateHash(Salt[1], "admin"),
                    Slika = File.ReadAllBytes("profilna1.jpg")
                },
                new Korisnici()
                {
                    KorisniciId = 3003,
                    Ime = "Uposlenik",
                    Prezime = "Uposlenik",
                    Email = "uposlenik@gmail.com",
                    Telefon = "063132233",
                    KorisnickoIme = "uposlenik",
                    LozinkaSalt = Salt[2],
                    LozinkaHash = KlijentiService.GenerateHash(Salt[2], "uposlenik"),
                    Slika = File.ReadAllBytes("profilna1.jpg")
                });
            #endregion

            #region Dodavanje korisnickih uloga korisnicima
            modelBuilder.Entity<KorisniciUloge>().HasData(
                new KorisniciUloge()
                {
                    KorisniciUlogeId = 1,
                    KorisniciId = 2002,
                    UlogeId = 1,
                    DatumIzmjene = DateTime.Now
                },
                new KorisniciUloge()
                {
                    KorisniciUlogeId = 2,
                    KorisniciId = 3002,
                    UlogeId = 1,
                    DatumIzmjene = DateTime.Now
                },
                new KorisniciUloge()
                {
                    KorisniciUlogeId = 3,
                    KorisniciId = 3003,
                    UlogeId = 2,
                    DatumIzmjene = DateTime.Now
                });
            #endregion

            #region Dodavanje ocjena
            modelBuilder.Entity<Ocjene>().HasData(
                new Ocjene()
                {
                    OcjeneId = 5005,
                    ArtikliId = 4012,
                    KlijentiId = 6002,
                    Ocjena = 3,
                    Komentar = ""
                },
                  new Ocjene()
                  {
                      OcjeneId = 5004,
                      ArtikliId = 2012,
                      KlijentiId = 6002,
                      Ocjena = 5,
                      Komentar = ""
                  });
            #endregion

            #region Dodavanje narudzbi
            modelBuilder.Entity<Narudzba>().HasData(
                new Narudzba()
                {
                    NarudzbaId = 10009,
                    BrojNarudzbe = "N10009",
                    KlijentiId = 6002,
                    DatumNarudzbe = DateTime.Now,
                    IznosBezPdv = Convert.ToDecimal(39.98),
                    IznosSaPdv = Convert.ToDecimal(46.78),
                    KorisniciId = 3003
                },
                 new Narudzba()
                 {
                     NarudzbaId = 10008,
                     BrojNarudzbe = "N10008",
                     KlijentiId = 6002,
                     DatumNarudzbe = DateTime.Now,
                     IznosBezPdv = Convert.ToDecimal(179.80),
                     IznosSaPdv = Convert.ToDecimal(210.37),
                     KorisniciId = 3003
                 }
                );
            #endregion
            #region Dodavanje stavki narudzbe
            modelBuilder.Entity<NarudzbaStavke>().HasData(
                new NarudzbaStavke()
                {
                    NarudzbaStavkeId = 8009,
                    NarudzbaId = 10008,
                    ArtikliId = 2013,
                    Kolicina = 1,
                    Cijena = Convert.ToDecimal(89.90), 
                    Popust=0
                },
                new NarudzbaStavke()
                {
                    NarudzbaStavkeId = 8008,
                    NarudzbaId = 10008,
                    ArtikliId = 16,
                    Kolicina = 1,
                    Cijena = Convert.ToDecimal(89.90),
                    Popust = 0
                },
                new NarudzbaStavke()
                {
                    NarudzbaStavkeId = 8010,
                    NarudzbaId = 10009,
                    ArtikliId = 2012,
                    Kolicina = 2,
                    Cijena = Convert.ToDecimal(19.99), 
                    Popust=0
                });
            #endregion

        }
    }
}
