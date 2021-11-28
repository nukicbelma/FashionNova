using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FashionNova.Database
{
    public partial class FashionNova_IB170007Context : DbContext
    {
        public FashionNova_IB170007Context()
        {
        }

        public FashionNova_IB170007Context(DbContextOptions<FashionNova_IB170007Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Artikli> Artikli { get; set; }
        public virtual DbSet<Boja> Boja { get; set; }
        public virtual DbSet<Klijenti> Klijenti { get; set; }
        public virtual DbSet<Korisnici> Korisnici { get; set; }
        public virtual DbSet<KorisniciUloge> KorisniciUloge { get; set; }
        public virtual DbSet<Materijal> Materijal { get; set; }
        public virtual DbSet<NabavkaStavke> NabavkaStavke { get; set; }
        public virtual DbSet<Narudzba> Narudzba { get; set; }
        public virtual DbSet<Ocjene> Ocjene { get; set; }
        public virtual DbSet<Uloge> Uloge { get; set; }
        public virtual DbSet<Velicina> Velicina { get; set; }
        public virtual DbSet<VrstaArtikla> VrstaArtikla { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-5M800VH\\MSSQLSERVER_OLAP;Initial Catalog=FashionNova_IB170007; user=sa;password=belma51");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artikli>(entity =>
            {
                entity.HasKey(e => e.ArtikalId)
                    .HasName("PK__Artikli__2D92823AEDA01F94");

                entity.Property(e => e.ArtikalId).HasColumnName("ArtikalID");

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
                entity.HasKey(e => e.KlijentId)
                    .HasName("PK__Klijenti__5F05D84E879B2183");

                entity.Property(e => e.KlijentId).HasColumnName("KlijentID");

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
                entity.HasKey(e => e.KorisnikId)
                    .HasName("PK__Korisnic__80B06D61D47541A7");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

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
                entity.HasKey(e => e.KorisnikUlogaId)
                    .HasName("PK__Korisnic__1608720E1D2D9BEC");

                entity.Property(e => e.KorisnikUlogaId).HasColumnName("KorisnikUlogaID");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_KorisnikID");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.UlogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_UlogaID");
            });

            modelBuilder.Entity<Materijal>(entity =>
            {
                entity.Property(e => e.MaterijalId).HasColumnName("MaterijalID");

                entity.Property(e => e.Naziv).HasMaxLength(20);
            });

            modelBuilder.Entity<NabavkaStavke>(entity =>
            {
                entity.HasKey(e => e.NabavkeStavkeId)
                    .HasName("PK__NabavkaS__289BDCCD30764512");

                entity.Property(e => e.NabavkeStavkeId).HasColumnName("NabavkeStavkeID");

                entity.Property(e => e.ArtikalId).HasColumnName("ArtikalID");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NarudzbaId).HasColumnName("NarudzbaID");

                entity.Property(e => e.Popust).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Artikal)
                    .WithMany(p => p.NabavkaStavke)
                    .HasForeignKey(d => d.ArtikalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ArtikalID");

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.NabavkaStavke)
                    .HasForeignKey(d => d.NarudzbaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_NarudzbaID");
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

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Narudzba)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk2_KorisnikID");
            });

            modelBuilder.Entity<Ocjene>(entity =>
            {
                entity.HasKey(e => e.OcjenaId)
                    .HasName("PK__Ocjene__E6FC7B499112D726");

                entity.Property(e => e.OcjenaId).HasColumnName("OcjenaID");

                entity.Property(e => e.ArtikalId).HasColumnName("ArtikalID");

                entity.Property(e => e.KlijentId).HasColumnName("KlijentID");

                entity.Property(e => e.Komentar).HasMaxLength(100);

                entity.HasOne(d => d.Artikal)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.ArtikalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk2_ArtikalID");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.KlijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_KlijentID");
            });

            modelBuilder.Entity<Uloge>(entity =>
            {
                entity.HasKey(e => e.UlogaId)
                    .HasName("PK__Uloge__DCAB23EB8521EE24");

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
