//using Microsoft.EntityFrameworkCore;
//using FashionNova.WebAPI.Services;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using FashionNova.Services;
//using FashionNova.Database;

//namespace FashionNova.WebAPI
//{
//    public partial class FashionNova_IB170007ContextData
//    {
//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
//        {
//            List<string> Salt = new List<string>();
//            for (int i = 0; i < 5; i++)
//            {
//                Salt.Add(KorisniciService.GenerateSalt());
//            }

//            for (int i = 0; i < 5; i++)
//            {
//                Salt.Add(KlijentiService.GenerateSalt());
//            }

//            #region Dodavanje uloga
//            modelBuilder.Entity<Uloge>().HasData(
//                new Uloge()
//                {
//                    UlogaId = 1,
//                    Naziv = "Admin",
//                    OpisUloge ="Upravljanje sistemom"
//                },
//                new Uloge()
//                {
//                    UlogaId = 2,
//                    Naziv = "Uposlenik",
//                    OpisUloge = "Rad na sistemu"
//                });
//            #endregion

//            #region Dodavanje artikala
//            modelBuilder.Entity<Artikli>().HasData(
//                new Artikli()
//                {
//                    ArtikalId = 12,
//                    Naziv = "Trenerka 'BeFit'",
//                    Sifra = "AA00",
//                    Cijena = (decimal?)39.00,
//                    Slika = null,
//                    BojaId=2,
//                    MaterijalId=1,
//                    VelicinaId=4,
//                    VrstaArtiklaId=7
//                },
//               new Artikli()
//               {
//                   ArtikalId = 15,
//                   Naziv = "Trenerka 'BeFit'",
//                   Sifra = "AA00",
//                   Cijena = (decimal?)39.00,
//                   Slika = null,
//                   BojaId = 7,
//                   MaterijalId = 1,
//                   VelicinaId = 5,
//                   VrstaArtiklaId = 7
//               },
//                  new Artikli()
//                  {
//                      ArtikalId = 16,
//                      Naziv = "Haljina 'La Perla'",
//                      Sifra = "AA11",
//                      Cijena = (decimal?)89.90,
//                      Slika = null,
//                      BojaId = 7,
//                      MaterijalId = 7,
//                      VelicinaId = 3,
//                      VrstaArtiklaId = 6
//                  },
//                    new Artikli()
//                    {
//                        ArtikalId = 18,
//                        Naziv = "Farmerke 'BeTrendy'",
//                        Sifra = "AA22",
//                        Cijena = (decimal?)49.00,
//                        Slika = null,
//                        BojaId = 4,
//                        MaterijalId = 3,
//                        VelicinaId = 6,
//                        VrstaArtiklaId = 2
//                    }, new Artikli()
//                    {
//                        ArtikalId = 2012,
//                        Naziv = "Majica 'trendy'",
//                        Sifra = "CC11",
//                        Cijena = (decimal?)19.90,
//                        Slika = null,
//                        BojaId = 1,
//                        MaterijalId = 1,
//                        VelicinaId =1,
//                        VrstaArtiklaId = 1
//                    },
//                      new Artikli()
//                      {
//                          ArtikalId = 2013,
//                          Naziv = "Jakna 'Merci'",
//                          Sifra = "DD43",
//                          Cijena = (decimal?)89.90,
//                          Slika = null,
//                          BojaId = 8,
//                          MaterijalId = 4,
//                          VelicinaId = 1,
//                          VrstaArtiklaId = 3
//                      }, new Artikli()
//                      {
//                          ArtikalId = 3012,
//                          Naziv = "Hlace mom",
//                          Sifra = "DD55",
//                          Cijena = (decimal?)48.80,
//                          Slika = null,
//                          BojaId = 4,
//                          MaterijalId = 3,
//                          VelicinaId = 1,
//                          VrstaArtiklaId = 2
//                      }, new Artikli()
//                      {
//                          ArtikalId = 4012,
//                          Naziv = "Majica red4fun",
//                          Sifra = "DT15",
//                          Cijena = (decimal?)9.90,
//                          Slika = null,
//                          BojaId = 1,
//                          MaterijalId = 1,
//                          VelicinaId = 1,
//                          VrstaArtiklaId = 1
//                      });
//            #endregion
//            #region Dodavanje vrsta artikla
//            modelBuilder.Entity<VrstaArtikla>().HasData(
//                new VrstaArtikla()
//                {
//                    VrstaArtiklaId = 1,
//                    Naziv = "Majice",

//                },
//                 new VrstaArtikla()
//                 {
//                     VrstaArtiklaId = 2,
//                     Naziv = "Farmerke",
//                 },
//                  new VrstaArtikla()
//                  {
//                      VrstaArtiklaId = 3,
//                      Naziv = "Jakne",
//                  },
//                  new VrstaArtikla()
//                  {
//                      VrstaArtiklaId = 4,
//                      Naziv = "Suknje",
//                  },
//                  new VrstaArtikla()
//                  {
//                      VrstaArtiklaId = 5,
//                      Naziv = "Dukserice",
//                  }, new VrstaArtikla()
//                  {
//                      VrstaArtiklaId = 6,
//                      Naziv = "Haljine",
//                  }, new VrstaArtikla()
//                  {
//                      VrstaArtiklaId = 7,
//                      Naziv = "Trenerke",
//                  }, new VrstaArtikla()
//                  {
//                      VrstaArtiklaId = 1006,
//                      Naziv = "Pidzame",
//                  });
//            #endregion
//            #region Dodavanje materijala
//            modelBuilder.Entity<Materijal>().HasData(
//                new Materijal()
//                {
//                    MaterijalId = 1,
//                    Naziv = "Pamuk",

//                },
//                 new Materijal()
//                 {
//                     MaterijalId = 2,
//                     Naziv = "Poliester",
//                 },
//                  new Materijal()
//                  {
//                      MaterijalId = 3,
//                      Naziv = "Jeans",
//                  },
//                  new Materijal()
//                  {
//                      MaterijalId = 4,
//                      Naziv = "Velur",
//                  },
//                  new Materijal()
//                  {
//                      MaterijalId = 5,
//                      Naziv = "Koža",
//                  }, new Materijal()
//                  {
//                      MaterijalId = 6,
//                      Naziv = "Svila",
//                  }, new Materijal()
//                  {
//                      MaterijalId = 7,
//                      Naziv = "Saten",
//                  }, new Materijal()
//                  {
//                      MaterijalId = 1006,
//                      Naziv = "Vuna",
//                  });
//            #endregion
//            #region Dodavanje velicina
//            modelBuilder.Entity<Velicina>().HasData(
//                new Velicina()
//                {
//                    VelicinaId = 1,
//                    Oznaka = "XXS",

//                },
//                 new Velicina()
//                 {
//                     VelicinaId = 2,
//                     Oznaka = "XS",
//                 },
//                  new Velicina()
//                  {
//                      VelicinaId = 3,
//                      Oznaka = "S",
//                  },
//                  new Velicina()
//                  {
//                      VelicinaId = 4,
//                      Oznaka = "M",
//                  },
//                  new Velicina()
//                  {
//                      VelicinaId = 5,
//                      Oznaka = "L",
//                  }, new Velicina()
//                  {
//                      VelicinaId = 6,
//                      Oznaka = "XL",
//                  }, new Velicina()
//                  {
//                      VelicinaId  = 7,
//                      Oznaka = "XXL",
//                  }, new Velicina()
//                  {
//                      VelicinaId = 8,
//                      Oznaka = "XXXL",
//                  });
//            #endregion

//            #region Dodavanje boja
//            modelBuilder.Entity<Boja>().HasData(
//                new Boja()
//                {
//                    BojaId = 1,
//                    Naziv = "Crvena",

//                },
//                 new Boja()
//                 {
//                     BojaId = 2,
//                     Naziv = "Narandzasta",
//                 },
//                  new Boja()
//                  {
//                      BojaId = 3,
//                      Naziv = "Zuta",
//                  },
//                  new Boja()
//                  {
//                      BojaId = 4,
//                      Naziv = "Plava",
//                  },
//                  new Boja()
//                  {
//                      BojaId = 5,
//                      Naziv = "Zelena",
//                  }, new Boja()
//                  {
//                      BojaId = 6,
//                      Naziv = "Ljubicasta",
//                  }, new Boja()
//                  {
//                      BojaId = 7,
//                      Naziv = "Smedja",
//                  }, new Boja()
//                  {
//                      BojaId = 8,
//                      Naziv = "Crna",
//                  }, new Boja()
//                  {
//                      BojaId = 9,
//                      Naziv = "Siva",
//                  }, new Boja()
//                  {
//                      BojaId = 10,
//                      Naziv = "Tamnoplava",
//                  }, new Boja()
//                  {
//                      BojaId = 11,
//                      Naziv = "Lila",
//                  }, new Boja()
//                  {
//                      BojaId = 12,
//                      Naziv = "Bordo",
//                  });
//            #endregion


//            #region Dodavanje klijenata
//            modelBuilder.Entity<Klijenti>().HasData(
//                new Klijenti()
//                {
//                    KlijentId = 1,
//                    Ime = "Belma",
//                    Prezime = "Nukic",
//                    DatumRegistracijeRacuna = DateTime.Now,
//                    Email ="belma@live.com",
//                    Telefon = "123123",
//                    KorisnickoIme = "belma",
//                    Slika=null,
//                    LozinkaSalt = Salt[0],
//                    LozinkaHash = KlijentiService.GenerateHash(Salt[0], "belma")
//                });
//            #endregion

//            #region Dodavanje korisnika
//            modelBuilder.Entity<Korisnici>().HasData(
//                new Korisnici()
//                {
//                    KorisnikId = 2002,
//                    Ime = "hanna",
//                    Prezime = "hanna",
//                    Email = "hanna@example.com",
//                    Telefon = "123",
//                    KorisnickoIme = "hanna",
//                    LozinkaSalt = Salt[0],
//                    Slika=null,
//                    LozinkaHash = KlijentiService.GenerateHash(Salt[0], "hanna")
//                },
//                new Korisnici()
//                {
//                    KorisnikId = 3002,
//                    Ime = "Admin",
//                    Prezime = "Admin",
//                    Email = "admin@gmail.com",
//                    Telefon = "063222111",
//                    KorisnickoIme = "admin",
//                    LozinkaSalt = Salt[1],
//                    LozinkaHash = KlijentiService.GenerateHash(Salt[1], "admin"),
//                    Slika=null
//                },
//                new Korisnici()
//                {
//                    KorisnikId = 3003,
//                    Ime = "Uposlenik",
//                    Prezime = "Uposlenik",
//                    Email = "uposlenik@gmail.com",
//                    Telefon = "063132233",
//                    KorisnickoIme = "uposlenik",
//                    LozinkaSalt = Salt[2],
//                    LozinkaHash = KlijentiService.GenerateHash(Salt[2], "uposlenik"),
//                    Slika=null
//                });
//            #endregion

//            #region Dodavanje korisnickih uloga korisnicima
//            modelBuilder.Entity<KorisniciUloge>().HasData(
//                new KorisniciUloge()
//                {
//                    KorisnikUlogaId = 1,
//                    KorisnikId = 2002,
//                    UlogaId = 1,
//                    DatumIzmjene = DateTime.Now
//                },
//                new KorisniciUloge()
//                {
//                    KorisnikUlogaId = 2,
//                    KorisnikId = 3002,
//                    UlogaId = 1,
//                    DatumIzmjene = DateTime.Now
//                },
//                new KorisniciUloge()
//                {
//                    KorisnikUlogaId = 3,
//                    KorisnikId = 3003,
//                    UlogaId = 2,
//                    DatumIzmjene = DateTime.Now
//                });
//            #endregion

//            #region Dodavanje ocjena
//            modelBuilder.Entity<Ocjene>().HasData(
//                new Ocjene()
//                {
//                    OcjenaId = 2,
//                    ArtikalId = 12,
//                    KlijentId = 1,
//                    Ocjena = 5,
//                    Komentar = ""
//                },
//                  new Ocjene()
//                  {
//                      OcjenaId = 3,
//                      ArtikalId = 18,
//                      KlijentId = 1,
//                      Ocjena = 4,
//                      Komentar = "Super"
//                  });
//            #endregion


//            #region Dodavanje stavki nabavke
//            modelBuilder.Entity<NabavkaStavke>().HasData(
//                new NabavkaStavke()
//                {
//                    NabavkaStavkeId = 1,
//                    NabavkaId =1,
//                    ArtikalId = 1,
//                    Kolicina = 1,
//                    Cijena = 1200
//                },
//                new NabavkaStavke()
//                {
//                    NabavkaStavkeId = 2,
//                    NabavkaId = 2,
//                    ArtikalId = 2,
//                    Kolicina = 1,
//                    Cijena = 1200
//                });
//            #endregion

//            #region Dodavanje narudzbi
//            modelBuilder.Entity<Narudzbe>().HasData(
//                new Narudzbe()
//                {
//                    NarudzbaId = 2,
//                    BrojNarudzbe = "1",
//                   // KlijentId = 1,
//                    DatumNarudzbe = DateTime.Now,
//                    IznosBezPdv = 1000,
//                    IznosSaPdv = 1170,
//                    KorisnikId = 2002
//                });
//            #endregion

//            #region Dodavanje stavki narudzbe
//            modelBuilder.Entity<NarudzbeStavke>().HasData(
//                new NarudzbeStavke()
//                {
//                    NarudzbeStavkaId = 1,
//                    NarudzbaId = 1,
//                    Kolicina = 1,
//                    Cijena = 1200,
//                    Popust = 10,
//                    ArtikalId = 2,
//                },
//                new NarudzbeStavke()
//                {
//                    NarudzbeStavkaId = 2,
//                    NarudzbaId = 2,
//                    Kolicina = 1,
//                    Cijena = 900,
//                    Popust = 0,
//                    ArtikalId = 1,
//                },
//                new NarudzbeStavke()
//                {
//                    NarudzbeStavkaId = 3,
//                    NarudzbaId = 2,
//                    Kolicina = 1,
//                    Cijena = 1800,
//                    Popust = 0,
//                    ArtikalId = 3,
//                });
//            #endregion

//        }
//    }
//}
