using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstadoCuenta.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ActualizaciondeSaldos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 850m, 9150m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 480m, 7520m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 710m, 4290m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 940m, 14060m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 1170m, 10830m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 1400m, 4600m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 1630m, 18370m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 1860m, 5140m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 2090m, 11910m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 2320m, 6680m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 2550m, 7450m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 2130m, 5370m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 1590m, 6410m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 960m, 9040m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 270m, 10730m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 5000m, 5000m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 3000m, 5000m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 1500m, 3500m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 7000m, 8000m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 4000m, 8000m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 2000m, 4000m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 10000m, 10000m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 2500m, 4500m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 6000m, 8000m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 3500m, 5500m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 4000m, 6000m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 2500m, 5000m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 3000m, 5000m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 4500m, 5500m });

            migrationBuilder.UpdateData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "SaldoActual", "SaldoDisponible" },
                values: new object[] { 5000m, 6000m });
        }
    }
}
