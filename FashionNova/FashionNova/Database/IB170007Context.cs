using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FashionNova.WebAPI.DB;
using System.Linq;

namespace FashionNova.WebAPI.Database
{
    public partial class IB170007Context : DbContext
    {
        public IB170007Context()
        {
        }

        public IB170007Context(DbContextOptions<IB170007Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Artikli> Artikli { get; set; }
        public virtual DbSet<Boja> Boja { get; set; }
        public virtual DbSet<Klijenti> Klijenti { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<KorisniciUloge> KorisniciUloge { get; set; }
        public virtual DbSet<Materijal> Materijal { get; set; }
        public virtual DbSet<Narudzba> Narudzba { get; set; }
        public virtual DbSet<NarudzbaStavke> NarudzbaStavke { get; set; }
        public virtual DbSet<Ocjene> Ocjene { get; set; }
        public virtual DbSet<Uloge> Uloge { get; set; }
        public virtual DbSet<Velicina> Velicina { get; set; }
        public virtual DbSet<VrstaArtikla> VrstaArtikla { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-5M800VH\\MSSQLSERVER_OLAP;Database=IB170007;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Artikli>(entity =>
            {
                entity.Property(e => e.ArtikliId).HasColumnName("ArtikliID");

                entity.Property(e => e.BojaId).HasColumnName("BojaID");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaterijalId).HasColumnName("MaterijalID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sifra)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.VelicinaId).HasColumnName("VelicinaID");

                entity.Property(e => e.VrstaArtiklaId).HasColumnName("VrstaArtiklaID");

                entity.HasOne(d => d.Boja)
                    .WithMany(p => p.Artikli)
                    .HasForeignKey(d => d.BojaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_BojaID");

                entity.HasOne(d => d.Materijal)
                    .WithMany(p => p.Artikli)
                    .HasForeignKey(d => d.MaterijalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MaterijalID");

                entity.HasOne(d => d.Velicina)
                    .WithMany(p => p.Artikli)
                    .HasForeignKey(d => d.VelicinaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Velicina");

                entity.HasOne(d => d.VrstaArtikla)
                    .WithMany(p => p.Artikli)
                    .HasForeignKey(d => d.VrstaArtiklaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_VrstaArtiklaID");
            });

            modelBuilder.Entity<Boja>(entity =>
            {
                entity.Property(e => e.BojaId).HasColumnName("BojaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Klijenti>(entity =>
            {
                entity.Property(e => e.KlijentiId).HasColumnName("KlijentiID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash).IsRequired();

                entity.Property(e => e.LozinkaSalt).IsRequired();

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Korisnici>(entity =>
            {
                entity.Property(e => e.KorisniciId).HasColumnName("KorisniciID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash).IsRequired();

                entity.Property(e => e.LozinkaSalt).IsRequired();

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Telefon)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<KorisniciUloge>(entity =>
            {
                entity.Property(e => e.KorisniciUlogeId).HasColumnName("KorisniciUlogeID");

                entity.Property(e => e.KorisniciId).HasColumnName("KorisniciID");

                entity.Property(e => e.UlogeId).HasColumnName("UlogeID");

                entity.HasOne(d => d.Korisnici)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.KorisniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_KorisnikID");

                entity.HasOne(d => d.Uloge)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.UlogeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_UlogaID");
            });

            modelBuilder.Entity<Materijal>(entity =>
            {
                entity.Property(e => e.MaterijalId).HasColumnName("MaterijalID");

                entity.Property(e => e.Naziv).HasMaxLength(20);
            });

            modelBuilder.Entity<Narudzba>(entity =>
            {
                entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

                entity.Property(e => e.BrojNarudzbe)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IznosBezPdv)
                    .HasColumnName("IznosBezPDV")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IznosSaPdv)
                    .HasColumnName("IznosSaPDV")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KlijentiId).HasColumnName("KlijentiID");

                entity.Property(e => e.KorisniciId).HasColumnName("KorisniciID");

                entity.HasOne(d => d.Klijenti)
                    .WithMany(p => p.Narudzba)
                    .HasForeignKey(d => d.KlijentiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk2_KlijentID");

                entity.HasOne(d => d.Korisnici)
                    .WithMany(p => p.Narudzba)
                    .HasForeignKey(d => d.KorisniciId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk2_KorisnikID");
            });

            modelBuilder.Entity<NarudzbaStavke>(entity =>
            {
                entity.Property(e => e.NarudzbaStavkeId).HasColumnName("NarudzbaStavkeID");

                entity.Property(e => e.ArtikliId).HasColumnName("ArtikliID");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

                entity.Property(e => e.Popust).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Artikli)
                    .WithMany(p => p.NarudzbaStavke)
                    .HasForeignKey(d => d.ArtikliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ArtikalID");

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.NarudzbaStavke)
                    .HasForeignKey(d => d.NarudzbaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_NarudzbaID");
            });

            modelBuilder.Entity<Ocjene>(entity =>
            {
                entity.Property(e => e.OcjeneId).HasColumnName("OcjeneID");

                entity.Property(e => e.ArtikliId).HasColumnName("ArtikliID");

                entity.Property(e => e.KlijentiId).HasColumnName("KlijentiID");

                entity.Property(e => e.Komentar).HasMaxLength(100);

                entity.HasOne(d => d.Artikli)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.ArtikliId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk2_ArtikalID");

                entity.HasOne(d => d.Klijenti)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.KlijentiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_KlijentID");
            });

            modelBuilder.Entity<Uloge>(entity =>
            {
                entity.Property(e => e.UlogeId).HasColumnName("UlogeID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.OpisUloge)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Velicina>(entity =>
            {
                entity.Property(e => e.VelicinaId).HasColumnName("VelicinaID");

                entity.Property(e => e.Oznaka)
                    .IsRequired()
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<VrstaArtikla>(entity =>
            {
                entity.Property(e => e.VrstaArtiklaId).HasColumnName("VrstaArtiklaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(20);
            });


            modelBuilder.Seed();
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
