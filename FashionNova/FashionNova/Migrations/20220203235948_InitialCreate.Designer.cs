﻿// <auto-generated />
using System;
using FashionNova.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FashionNova.WebAPI.Migrations
{
    [DbContext(typeof(FashionNova_IB170007Context))]
    [Migration("20220203235948_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FashionNova.WebAPI.Database.Artikli", b =>
                {
                    b.Property<int>("ArtikalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ArtikalID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BojaId")
                        .HasColumnName("BojaID")
                        .HasColumnType("int");

                    b.Property<decimal?>("Cijena")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("MaterijalId")
                        .HasColumnName("MaterijalID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Sifra")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("VelicinaId")
                        .HasColumnName("VelicinaID")
                        .HasColumnType("int");

                    b.Property<int>("VrstaArtiklaId")
                        .HasColumnName("VrstaArtiklaID")
                        .HasColumnType("int");

                    b.HasKey("ArtikalId")
                        .HasName("PK__Artikli__2D92823AEDA01F94");

                    b.HasIndex("BojaId");

                    b.HasIndex("MaterijalId");

                    b.HasIndex("VelicinaId");

                    b.HasIndex("VrstaArtiklaId");

                    b.ToTable("Artikli");
                });

            modelBuilder.Entity("FashionNova.WebAPI.Database.Boja", b =>
                {
                    b.Property<int>("BojaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("BojaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("BojaId");

                    b.ToTable("Boja");
                });

            modelBuilder.Entity("FashionNova.WebAPI.Database.Klijenti", b =>
                {
                    b.Property<int>("KlijentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KlijentID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumRegistracijeRacuna")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LozinkaHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("KlijentId")
                        .HasName("PK__Klijenti__5F05D84E879B2183");

                    b.ToTable("Klijenti");
                });

            modelBuilder.Entity("FashionNova.WebAPI.Database.Korisnici", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KorisnikID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LozinkaHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("KorisnikId")
                        .HasName("PK__Korisnic__80B06D61D47541A7");

                    b.ToTable("Korisnici");
                });

            modelBuilder.Entity("FashionNova.WebAPI.Database.KorisniciUloge", b =>
                {
                    b.Property<int>("KorisnikUlogaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("KorisnikUlogaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DatumIzmjene")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikId")
                        .HasColumnName("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int>("UlogaId")
                        .HasColumnName("UlogaID")
                        .HasColumnType("int");

                    b.HasKey("KorisnikUlogaId")
                        .HasName("PK__Korisnic__1608720E1D2D9BEC");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("UlogaId");

                    b.ToTable("KorisniciUloge");
                });

            modelBuilder.Entity("FashionNova.WebAPI.Database.Materijal", b =>
                {
                    b.Property<int>("MaterijalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MaterijalID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("MaterijalId");

                    b.ToTable("Materijal");
                });

            modelBuilder.Entity("FashionNova.WebAPI.Database.Narudzba", b =>
                {
                    b.Property<int>("NarudzbaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("NarudzbaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojNarudzbe")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<DateTime>("DatumNarudzbe")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("IznosBezPdv")
                        .HasColumnName("IznosBezPDV")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("IznosSaPdv")
                        .HasColumnName("IznosSaPDV")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("KlijentId")
                        .HasColumnName("KlijentID")
                        .HasColumnType("int");

                    b.Property<int>("KorisnikId")
                        .HasColumnName("KorisnikID")
                        .HasColumnType("int");

                    b.HasKey("NarudzbaId");

                    b.HasIndex("KlijentId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Narudzba");
                });

            modelBuilder.Entity("FashionNova.WebAPI.Database.NarudzbaStavke", b =>
                {
                    b.Property<int>("NarudzbaStavkeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("NarudzbaStavkeID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtikalId")
                        .HasColumnName("ArtikalID")
                        .HasColumnType("int");

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int>("NarudzbaId")
                        .HasColumnName("NarudzbaID")
                        .HasColumnType("int");

                    b.Property<decimal>("Popust")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("NarudzbaStavkeId");

                    b.HasIndex("ArtikalId");

                    b.HasIndex("NarudzbaId");

                    b.ToTable("NarudzbaStavke");
                });

            modelBuilder.Entity("FashionNova.WebAPI.Database.Ocjene", b =>
                {
                    b.Property<int>("OcjenaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("OcjenaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtikalId")
                        .HasColumnName("ArtikalID")
                        .HasColumnType("int");

                    b.Property<int>("KlijentId")
                        .HasColumnName("KlijentID")
                        .HasColumnType("int");

                    b.Property<string>("Komentar")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Ocjena")
                        .HasColumnType("int");

                    b.HasKey("OcjenaId")
                        .HasName("PK__Ocjene__E6FC7B499112D726");

                    b.HasIndex("ArtikalId");

                    b.HasIndex("KlijentId");

                    b.ToTable("Ocjene");
                });

            modelBuilder.Entity("FashionNova.WebAPI.Database.Uloge", b =>
                {
                    b.Property<int>("UlogaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UlogaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("OpisUloge")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.HasKey("UlogaId")
                        .HasName("PK__Uloge__DCAB23EB8521EE24");

                    b.ToTable("Uloge");
                });

            modelBuilder.Entity("FashionNova.WebAPI.Database.Velicina", b =>
                {
                    b.Property<int>("VelicinaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("VelicinaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Oznaka")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.HasKey("VelicinaId");

                    b.ToTable("Velicina");
                });

            modelBuilder.Entity("FashionNova.WebAPI.Database.VrstaArtikla", b =>
                {
                    b.Property<int>("VrstaArtiklaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("VrstaArtiklaID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("VrstaArtiklaId");

                    b.ToTable("VrstaArtikla");
                });

            modelBuilder.Entity("FashionNova.WebAPI.Database.Artikli", b =>
                {
                    b.HasOne("FashionNova.WebAPI.Database.Boja", "Boja")
                        .WithMany("Artikli")
                        .HasForeignKey("BojaId")
                        .HasConstraintName("fk_BojaID")
                        .IsRequired();

                    b.HasOne("FashionNova.WebAPI.Database.Materijal", "Materijal")
                        .WithMany("Artikli")
                        .HasForeignKey("MaterijalId")
                        .HasConstraintName("fk_MaterijalID")
                        .IsRequired();

                    b.HasOne("FashionNova.WebAPI.Database.Velicina", "Velicina")
                        .WithMany("Artikli")
                        .HasForeignKey("VelicinaId")
                        .HasConstraintName("fk_Velicina")
                        .IsRequired();

                    b.HasOne("FashionNova.WebAPI.Database.VrstaArtikla", "VrstaArtikla")
                        .WithMany("Artikli")
                        .HasForeignKey("VrstaArtiklaId")
                        .HasConstraintName("fk_VrstaArtiklaID")
                        .IsRequired();
                });

            modelBuilder.Entity("FashionNova.WebAPI.Database.KorisniciUloge", b =>
                {
                    b.HasOne("FashionNova.WebAPI.Database.Korisnici", "Korisnik")
                        .WithMany("KorisniciUloge")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("fk_KorisnikID")
                        .IsRequired();

                    b.HasOne("FashionNova.WebAPI.Database.Uloge", "Uloga")
                        .WithMany("KorisniciUloge")
                        .HasForeignKey("UlogaId")
                        .HasConstraintName("fk_UlogaID")
                        .IsRequired();
                });

            modelBuilder.Entity("FashionNova.WebAPI.Database.Narudzba", b =>
                {
                    b.HasOne("FashionNova.WebAPI.Database.Klijenti", "Klijent")
                        .WithMany("Narudzba")
                        .HasForeignKey("KlijentId")
                        .HasConstraintName("fk2_KlijentID")
                        .IsRequired();

                    b.HasOne("FashionNova.WebAPI.Database.Korisnici", "Korisnik")
                        .WithMany("Narudzba")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("fk2_KorisnikID")
                        .IsRequired();
                });

            modelBuilder.Entity("FashionNova.WebAPI.Database.NarudzbaStavke", b =>
                {
                    b.HasOne("FashionNova.WebAPI.Database.Artikli", "Artikal")
                        .WithMany("NarudzbaStavke")
                        .HasForeignKey("ArtikalId")
                        .HasConstraintName("fk_ArtikalID")
                        .IsRequired();

                    b.HasOne("FashionNova.WebAPI.Database.Narudzba", "Narudzba")
                        .WithMany("NarudzbaStavke")
                        .HasForeignKey("NarudzbaId")
                        .HasConstraintName("fk_NarudzbaID")
                        .IsRequired();
                });

            modelBuilder.Entity("FashionNova.WebAPI.Database.Ocjene", b =>
                {
                    b.HasOne("FashionNova.WebAPI.Database.Artikli", "Artikal")
                        .WithMany("Ocjene")
                        .HasForeignKey("ArtikalId")
                        .HasConstraintName("fk2_ArtikalID")
                        .IsRequired();

                    b.HasOne("FashionNova.WebAPI.Database.Klijenti", "Klijent")
                        .WithMany("Ocjene")
                        .HasForeignKey("KlijentId")
                        .HasConstraintName("fk_KlijentID")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
