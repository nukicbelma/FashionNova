using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FashionNova.WebAPI.Migrations
{
    public partial class migracija1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentiID",
                keyValue: 6002,
                columns: new[] { "DatumRegistracijeRacuna", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2022, 2, 7, 20, 18, 50, 885, DateTimeKind.Local).AddTicks(4490), "3dxzcyZ9fqZvOnD/MKPVHCr0cvs=", "FhlQj2xgcVBfqoJyeOxGRA==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisniciID",
                keyValue: 2002,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "QhQ5fD7CAWcowxIlNCN3+R8Dzg4=", "FhlQj2xgcVBfqoJyeOxGRA==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisniciID",
                keyValue: 3002,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "5IWgTBN4V98upYKY2493KYJ72d4=", "i1l1JJMwQF3LevYpteDDPQ==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisniciID",
                keyValue: 3003,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "D9mruQTsbajgHpvlTUQY3hmbdjg=", "NjMgzHCe1GIUhguPAhC6Hg==" });

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisniciUlogeID",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2022, 2, 7, 20, 18, 50, 915, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisniciUlogeID",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2022, 2, 7, 20, 18, 50, 915, DateTimeKind.Local).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisniciUlogeID",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2022, 2, 7, 20, 18, 50, 915, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 10008,
                column: "DatumNarudzbe",
                value: new DateTime(2022, 2, 7, 20, 18, 50, 918, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 10009,
                column: "DatumNarudzbe",
                value: new DateTime(2022, 2, 7, 20, 18, 50, 917, DateTimeKind.Local).AddTicks(2237));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentiID",
                keyValue: 6002,
                columns: new[] { "DatumRegistracijeRacuna", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2022, 2, 7, 18, 49, 20, 207, DateTimeKind.Local).AddTicks(3307), "1vNvKwcfEnu8CSLCb5WbW+w0riA=", "o7BYZKGL/BYZK7tT8R8imQ==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisniciID",
                keyValue: 2002,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "8pyu1/rhlOl+pnWGE7z0nGGSrUE=", "o7BYZKGL/BYZK7tT8R8imQ==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisniciID",
                keyValue: 3002,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "wV0lNjD2eKbWuLHO1l0gsW4k/xY=", "Rr7/BPauFThWe6HkE48JpA==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisniciID",
                keyValue: 3003,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "qqhwYfc9XFdzc8tMzJ/bh2I1ads=", "Z8yN2kQ5RH98OIl6AldARA==" });

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisniciUlogeID",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2022, 2, 7, 18, 49, 20, 225, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisniciUlogeID",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2022, 2, 7, 18, 49, 20, 225, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisniciUlogeID",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2022, 2, 7, 18, 49, 20, 225, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 10008,
                column: "DatumNarudzbe",
                value: new DateTime(2022, 2, 7, 18, 49, 20, 226, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 10009,
                column: "DatumNarudzbe",
                value: new DateTime(2022, 2, 7, 18, 49, 20, 225, DateTimeKind.Local).AddTicks(9017));
        }
    }
}
