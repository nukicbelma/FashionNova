using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FashionNova.WebAPI.Migrations
{
    public partial class migracija2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentiID",
                keyValue: 6002,
                columns: new[] { "DatumRegistracijeRacuna", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2022, 2, 7, 20, 36, 26, 0, DateTimeKind.Local).AddTicks(2274), "6QJUHaCAinMS3WMzRJFEERUv4+0=", "EJT6h6/tpU9tBOqele4h8g==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisniciID",
                keyValue: 2002,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "yKhlI2/nLBh8+P5CAfzoFlgYrhk=", "EJT6h6/tpU9tBOqele4h8g==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisniciID",
                keyValue: 3002,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "yq/5KL/7yu1HK0zJOqOQhw0yAlg=", "2rY5PJtEjmB6lqw9ahO/BA==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisniciID",
                keyValue: 3003,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "1vFaslQnkkw1merKy03IFL4KU9I=", "OUY5UzvnpSsB+iXacRyY5w==" });

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisniciUlogeID",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2022, 2, 7, 20, 36, 26, 19, DateTimeKind.Local).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisniciUlogeID",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2022, 2, 7, 20, 36, 26, 19, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisniciUlogeID",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2022, 2, 7, 20, 36, 26, 19, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 10008,
                column: "DatumNarudzbe",
                value: new DateTime(2022, 2, 7, 20, 36, 26, 20, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaID",
                keyValue: 10009,
                column: "DatumNarudzbe",
                value: new DateTime(2022, 2, 7, 20, 36, 26, 20, DateTimeKind.Local).AddTicks(3739));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
