using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FashionNova.WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boja",
                columns: table => new
                {
                    BojaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boja", x => x.BojaID);
                });

            migrationBuilder.CreateTable(
                name: "Klijenti",
                columns: table => new
                {
                    KlijentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(maxLength: 30, nullable: false),
                    Prezime = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Telefon = table.Column<string>(maxLength: 20, nullable: false),
                    KorisnickoIme = table.Column<string>(maxLength: 50, nullable: false),
                    LozinkaHash = table.Column<string>(nullable: false),
                    LozinkaSalt = table.Column<string>(nullable: false),
                    DatumRegistracijeRacuna = table.Column<DateTime>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Klijenti__5F05D84E879B2183", x => x.KlijentID);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(maxLength: 30, nullable: false),
                    Prezime = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Telefon = table.Column<string>(maxLength: 20, nullable: false),
                    KorisnickoIme = table.Column<string>(maxLength: 50, nullable: false),
                    LozinkaHash = table.Column<string>(nullable: false),
                    LozinkaSalt = table.Column<string>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Korisnic__80B06D61D47541A7", x => x.KorisnikID);
                });

            migrationBuilder.CreateTable(
                name: "Materijal",
                columns: table => new
                {
                    MaterijalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materijal", x => x.MaterijalID);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    UlogaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 20, nullable: false),
                    OpisUloge = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Uloge__DCAB23EB8521EE24", x => x.UlogaID);
                });

            migrationBuilder.CreateTable(
                name: "Velicina",
                columns: table => new
                {
                    VelicinaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Oznaka = table.Column<string>(maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Velicina", x => x.VelicinaID);
                });

            migrationBuilder.CreateTable(
                name: "VrstaArtikla",
                columns: table => new
                {
                    VrstaArtiklaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VrstaArtikla", x => x.VrstaArtiklaID);
                });

            migrationBuilder.CreateTable(
                name: "Narudzba",
                columns: table => new
                {
                    NarudzbaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojNarudzbe = table.Column<string>(maxLength: 20, nullable: false),
                    DatumNarudzbe = table.Column<DateTime>(nullable: false),
                    IznosBezPDV = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    IznosSaPDV = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    KorisnikID = table.Column<int>(nullable: false),
                    KlijentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzba", x => x.NarudzbaID);
                    table.ForeignKey(
                        name: "fk2_KlijentID",
                        column: x => x.KlijentID,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk2_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KorisniciUloge",
                columns: table => new
                {
                    KorisnikUlogaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumIzmjene = table.Column<DateTime>(nullable: true),
                    KorisnikID = table.Column<int>(nullable: false),
                    UlogaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Korisnic__1608720E1D2D9BEC", x => x.KorisnikUlogaID);
                    table.ForeignKey(
                        name: "fk_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_UlogaID",
                        column: x => x.UlogaID,
                        principalTable: "Uloge",
                        principalColumn: "UlogaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Artikli",
                columns: table => new
                {
                    ArtikalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sifra = table.Column<string>(maxLength: 10, nullable: false),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    BojaID = table.Column<int>(nullable: false),
                    MaterijalID = table.Column<int>(nullable: false),
                    VelicinaID = table.Column<int>(nullable: false),
                    VrstaArtiklaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Artikli__2D92823AEDA01F94", x => x.ArtikalID);
                    table.ForeignKey(
                        name: "fk_BojaID",
                        column: x => x.BojaID,
                        principalTable: "Boja",
                        principalColumn: "BojaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_MaterijalID",
                        column: x => x.MaterijalID,
                        principalTable: "Materijal",
                        principalColumn: "MaterijalID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_Velicina",
                        column: x => x.VelicinaID,
                        principalTable: "Velicina",
                        principalColumn: "VelicinaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_VrstaArtiklaID",
                        column: x => x.VrstaArtiklaID,
                        principalTable: "VrstaArtikla",
                        principalColumn: "VrstaArtiklaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NarudzbaStavke",
                columns: table => new
                {
                    NarudzbaStavkeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kolicina = table.Column<int>(nullable: false),
                    Cijena = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Popust = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    NarudzbaID = table.Column<int>(nullable: false),
                    ArtikalID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NarudzbaStavke", x => x.NarudzbaStavkeID);
                    table.ForeignKey(
                        name: "fk_ArtikalID",
                        column: x => x.ArtikalID,
                        principalTable: "Artikli",
                        principalColumn: "ArtikalID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_NarudzbaID",
                        column: x => x.NarudzbaID,
                        principalTable: "Narudzba",
                        principalColumn: "NarudzbaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ocjene",
                columns: table => new
                {
                    OcjenaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ocjena = table.Column<int>(nullable: false),
                    Komentar = table.Column<string>(maxLength: 100, nullable: true),
                    ArtikalID = table.Column<int>(nullable: false),
                    KlijentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Ocjene__E6FC7B499112D726", x => x.OcjenaID);
                    table.ForeignKey(
                        name: "fk2_ArtikalID",
                        column: x => x.ArtikalID,
                        principalTable: "Artikli",
                        principalColumn: "ArtikalID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_KlijentID",
                        column: x => x.KlijentID,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artikli_BojaID",
                table: "Artikli",
                column: "BojaID");

            migrationBuilder.CreateIndex(
                name: "IX_Artikli_MaterijalID",
                table: "Artikli",
                column: "MaterijalID");

            migrationBuilder.CreateIndex(
                name: "IX_Artikli_VelicinaID",
                table: "Artikli",
                column: "VelicinaID");

            migrationBuilder.CreateIndex(
                name: "IX_Artikli_VrstaArtiklaID",
                table: "Artikli",
                column: "VrstaArtiklaID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_KorisnikID",
                table: "KorisniciUloge",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_UlogaID",
                table: "KorisniciUloge",
                column: "UlogaID");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_KlijentID",
                table: "Narudzba",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_KorisnikID",
                table: "Narudzba",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaStavke_ArtikalID",
                table: "NarudzbaStavke",
                column: "ArtikalID");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaStavke_NarudzbaID",
                table: "NarudzbaStavke",
                column: "NarudzbaID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_ArtikalID",
                table: "Ocjene",
                column: "ArtikalID");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_KlijentID",
                table: "Ocjene",
                column: "KlijentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KorisniciUloge");

            migrationBuilder.DropTable(
                name: "NarudzbaStavke");

            migrationBuilder.DropTable(
                name: "Ocjene");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Narudzba");

            migrationBuilder.DropTable(
                name: "Artikli");

            migrationBuilder.DropTable(
                name: "Klijenti");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "Boja");

            migrationBuilder.DropTable(
                name: "Materijal");

            migrationBuilder.DropTable(
                name: "Velicina");

            migrationBuilder.DropTable(
                name: "VrstaArtikla");
        }
    }
}
