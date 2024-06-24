using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EstadoCuenta.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoTitulares : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Titulares",
                columns: new[] { "Id", "Apellidos", "Nombre" },
                values: new object[,]
                {
                    { 1, "Pérez", "Juan" },
                    { 2, "García", "María" },
                    { 3, "Martínez", "Roberto" },
                    { 4, "Rodríguez", "Ana" },
                    { 5, "López", "Carlos" },
                    { 6, "Fernández", "Laura" },
                    { 7, "Sánchez", "Jorge" },
                    { 8, "Ramírez", "Sofía" },
                    { 9, "Gómez", "Diego" },
                    { 10, "Díaz", "Valeria" },
                    { 11, "Vargas", "Eduardo" },
                    { 12, "Castro", "Paola" },
                    { 13, "Morales", "Alejandro" },
                    { 14, "Herrera", "Adriana" },
                    { 15, "Núñez", "Guillermo" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
