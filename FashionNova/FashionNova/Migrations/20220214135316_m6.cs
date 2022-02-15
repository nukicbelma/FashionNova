using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FashionNova.WebAPI.Migrations
{
    public partial class m6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentiID",
                keyValue: 6002,
                columns: new[] { "DatumRegistracijeRacuna", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2022, 2, 14, 14, 53, 13, 327, DateTimeKind.Local).AddTicks(9547), "StOgO7Fw84Gjd+IP+qL0mV3ozSw=", "gFFIauGztQWH+Mbq5OTCvw==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisniciID",
                keyValue: 2002,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "Lf7+Uf6duQEQvw/qzSfmIJj1+6w=", "gFFIauGztQWH+Mbq5OTCvw==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisniciID",
                keyValue: 3002,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "sKKGDjv0fgnFGx31FP2R5OmssOM=", "+aBXPHKa6Zo+qszrUUqydw==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisniciID",
                keyValue: 3003,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "kXFa+pSxT0QqDFEPVv9agy/KiVU=", "XI0zFY3NfMej6kd23ta/2A==" });

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisniciUlogeID",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2022, 2, 14, 14, 53, 13, 356, DateTimeKind.Local).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisniciUlogeID",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2022, 2, 14, 14, 53, 13, 356, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisniciUlogeID",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2022, 2, 14, 14, 53, 13, 356, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 10008,
                column: "DatumNarudzbe",
                value: new DateTime(2022, 2, 14, 14, 53, 13, 359, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 10009,
                column: "DatumNarudzbe",
                value: new DateTime(2022, 2, 14, 14, 53, 13, 357, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.InsertData(
                table: "Narudzba",
                columns: new[] { "NarudzbaID", "BrojNarudzbe", "DatumNarudzbe", "IznosBezPDV", "IznosSaPDV", "KlijentiID", "KorisniciID" },
                values: new object[] { 10010, "N10010", new DateTime(2022, 2, 14, 14, 53, 13, 359, DateTimeKind.Local).AddTicks(305), 338.99m, 396.62m, 6002, 3003 });

            migrationBuilder.InsertData(
                table: "Ocjene",
                columns: new[] { "OcjeneID", "ArtikliID", "KlijentiID", "Komentar", "Ocjena" },
                values: new object[,]
                {
                    { 8, 18, 6002, "", 5 },
                    { 9, 15, 6002, "", 5 },
                    { 10, 12, 6002, "", 4 }
                });

            migrationBuilder.InsertData(
                table: "NarudzbaStavke",
                columns: new[] { "NarudzbaStavkeID", "ArtikliID", "Cijena", "Kolicina", "NarudzbaID", "Popust" },
                values: new object[] { 8011, 18, 49.9m, 1, 10010, 0m });

            migrationBuilder.InsertData(
                table: "NarudzbaStavke",
                columns: new[] { "NarudzbaStavkeID", "ArtikliID", "Cijena", "Kolicina", "NarudzbaID", "Popust" },
                values: new object[] { 8012, 5015, 250.99m, 1, 10010, 0m });

            migrationBuilder.InsertData(
                table: "NarudzbaStavke",
                columns: new[] { "NarudzbaStavkeID", "ArtikliID", "Cijena", "Kolicina", "NarudzbaID", "Popust" },
                values: new object[] { 8013, 15, 39m, 1, 10010, 0m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkeID",
                keyValue: 8011);

            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkeID",
                keyValue: 8012);

            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkeID",
                keyValue: 8013);

            migrationBuilder.DeleteData(
                table: "Ocjene",
                keyColumn: "OcjeneID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ocjene",
                keyColumn: "OcjeneID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ocjene",
                keyColumn: "OcjeneID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 10010);

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentiID",
                keyValue: 6002,
                columns: new[] { "DatumRegistracijeRacuna", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2022, 2, 14, 14, 3, 47, 835, DateTimeKind.Local).AddTicks(6745), "3LRE9m7SD1I65zZ/mboN2KwHHXY=", "sXbQsNPMUIRvPaJTFh07Lg==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisniciID",
                keyValue: 2002,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "lHn/vjvArGYyAG9KpGMW8MHsZcQ=", "sXbQsNPMUIRvPaJTFh07Lg==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisniciID",
                keyValue: 3002,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "D8lE2+LLZIVr/oXS4s64jllN8Vk=", "yHGAyL+Pnj1J+z0t2bGc6Q==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisniciID",
                keyValue: 3003,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "iP5fdYH1Y6GExMfgvbrmDR3Ccaw=", "pk3kJ86YkIHcwSqCfhJIiw==" });

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisniciUlogeID",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2022, 2, 14, 14, 3, 47, 863, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisniciUlogeID",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2022, 2, 14, 14, 3, 47, 864, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisniciUlogeID",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2022, 2, 14, 14, 3, 47, 864, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 10008,
                column: "DatumNarudzbe",
                value: new DateTime(2022, 2, 14, 14, 3, 47, 866, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 10009,
                column: "DatumNarudzbe",
                value: new DateTime(2022, 2, 14, 14, 3, 47, 865, DateTimeKind.Local).AddTicks(7386));
        }
    }
}
