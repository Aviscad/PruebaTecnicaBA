using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EstadoCuenta.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeederTipoTransacciones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TipoTransaccion",
                columns: new[] { "Id", "Tipo" },
                values: new object[,]
                {
                    { 1, "Compra" },
                    { 2, "Pago" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TipoTransaccion",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TipoTransaccion",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
