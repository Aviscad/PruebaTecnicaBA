using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EstadoCuenta.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TarjetasCredito",
                columns: new[] { "Id", "LimiteCredito", "NumeroTarjeta", "PorcentajeInteres", "PorcentajeSaldoMinimo", "SaldoActual", "SaldoDisponible", "TitularId" },
                values: new object[,]
                {
                    { 1, 10000m, "1111 **** **** 4444", 0.15m, 0.05m, 5000m, 5000m, 1 },
                    { 2, 8000m, "2222 **** **** 5555", 0.17m, 0.04m, 3000m, 5000m, 2 },
                    { 3, 5000m, "3333 **** **** 6666", 0.18m, 0.03m, 1500m, 3500m, 3 },
                    { 4, 15000m, "4444 **** **** 7777", 0.16m, 0.05m, 7000m, 8000m, 4 },
                    { 5, 12000m, "5555 **** **** 8888", 0.14m, 0.06m, 4000m, 8000m, 5 },
                    { 6, 6000m, "6666 **** **** 9999", 0.19m, 0.05m, 2000m, 4000m, 6 },
                    { 7, 20000m, "7777 **** **** 0000", 0.15m, 0.04m, 10000m, 10000m, 7 },
                    { 8, 7000m, "8888 **** **** 1111", 0.13m, 0.06m, 2500m, 4500m, 8 },
                    { 9, 14000m, "9999 **** **** 2222", 0.17m, 0.03m, 6000m, 8000m, 9 },
                    { 10, 9000m, "0000 **** **** 3333", 0.16m, 0.04m, 3500m, 5500m, 10 },
                    { 11, 10000m, "1111 **** **** 4444", 0.18m, 0.05m, 4000m, 6000m, 11 },
                    { 12, 7500m, "2222 **** **** 5555", 0.15m, 0.06m, 2500m, 5000m, 12 },
                    { 13, 8000m, "3333 **** **** 6666", 0.17m, 0.04m, 3000m, 5000m, 13 },
                    { 14, 10000m, "4444 **** **** 7777", 0.14m, 0.03m, 4500m, 5500m, 14 },
                    { 15, 11000m, "5555 **** **** 8888", 0.16m, 0.05m, 5000m, 6000m, 15 }
                });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Pérez Gómez", "Juan Carlos" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "García López", "María José" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Martínez Sánchez", "Roberto Carlos" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Rodríguez Díaz", "Ana María" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "López Fernández", "Carlos Alberto" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Fernández González", "Laura Patricia" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Sánchez Romero", "Jorge Luis" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Ramírez Torres", "Sofía Elena" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Gómez Navarro", "Diego Armando" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Díaz Herrera", "Valeria Sofía" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Vargas Cruz", "Eduardo Antonio" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Castro Morales", "Paola Andrea" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Morales García", "Alejandro Manuel" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Herrera Jiménez", "Adriana Beatriz" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Núñez Flores", "Guillermo Javier" });

            migrationBuilder.InsertData(
                table: "Compras",
                columns: new[] { "Id", "Descripcion", "Fecha", "Monto", "NumeroAutorizacion", "TarjetaCreditoId" },
                values: new object[,]
                {
                    { 1, "Compra en tienda A", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 123456, 1 },
                    { 2, "Compra en tienda B", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 150m, 123457, 1 },
                    { 3, "Compra en tienda C", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 200m, 123458, 1 },
                    { 4, "Compra en tienda D", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 250m, 123459, 1 },
                    { 5, "Compra en tienda E", new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, 123460, 1 },
                    { 6, "Compra en tienda F", new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 110m, 123461, 2 },
                    { 7, "Compra en tienda G", new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, 123462, 2 },
                    { 8, "Compra en tienda H", new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 130m, 123463, 2 },
                    { 9, "Compra en tienda I", new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 140m, 123464, 2 },
                    { 10, "Compra en tienda J", new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 150m, 123465, 2 },
                    { 11, "Compra en tienda K", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 160m, 123466, 3 },
                    { 12, "Compra en tienda L", new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, 123467, 3 },
                    { 13, "Compra en tienda M", new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 180m, 123468, 3 },
                    { 14, "Compra en tienda N", new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 190m, 123469, 3 },
                    { 15, "Compra en tienda O", new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 200m, 123470, 3 },
                    { 16, "Compra en tienda P", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 210m, 123471, 4 },
                    { 17, "Compra en tienda Q", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 220m, 123472, 4 },
                    { 18, "Compra en tienda R", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 230m, 123473, 4 },
                    { 19, "Compra en tienda S", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 240m, 123474, 4 },
                    { 20, "Compra en tienda T", new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 250m, 123475, 4 },
                    { 21, "Compra en tienda U", new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 260m, 123476, 5 },
                    { 22, "Compra en tienda V", new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 270m, 123477, 5 },
                    { 23, "Compra en tienda W", new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 280m, 123478, 5 },
                    { 24, "Compra en tienda X", new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 290m, 123479, 5 },
                    { 25, "Compra en tienda Y", new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, 123480, 5 },
                    { 26, "Compra en tienda Z", new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 310m, 123481, 6 },
                    { 27, "Compra en tienda AA", new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 320m, 123482, 6 },
                    { 28, "Compra en tienda BB", new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 330m, 123483, 6 },
                    { 29, "Compra en tienda CC", new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 340m, 123484, 6 },
                    { 30, "Compra en tienda DD", new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 350m, 123485, 6 },
                    { 31, "Compra en tienda EE", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 360m, 123486, 7 },
                    { 32, "Compra en tienda FF", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 370m, 123487, 7 },
                    { 33, "Compra en tienda GG", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 380m, 123488, 7 },
                    { 34, "Compra en tienda HH", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 390m, 123489, 7 },
                    { 35, "Compra en tienda II", new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 400m, 123490, 7 },
                    { 36, "Compra en tienda JJ", new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 410m, 123491, 8 },
                    { 37, "Compra en tienda KK", new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 420m, 123492, 8 },
                    { 38, "Compra en tienda LL", new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 430m, 123493, 8 },
                    { 39, "Compra en tienda MM", new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 440m, 123494, 8 },
                    { 40, "Compra en tienda NN", new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 450m, 123495, 8 },
                    { 41, "Compra en tienda OO", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 460m, 123496, 9 },
                    { 42, "Compra en tienda PP", new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 470m, 123497, 9 },
                    { 43, "Compra en tienda QQ", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 480m, 123498, 9 },
                    { 44, "Compra en tienda RR", new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 490m, 123499, 9 },
                    { 45, "Compra en tienda SS", new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m, 123500, 9 },
                    { 46, "Compra en tienda TT", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 510m, 123501, 10 },
                    { 47, "Compra en tienda UU", new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 520m, 123502, 10 },
                    { 48, "Compra en tienda VV", new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 530m, 123503, 10 },
                    { 49, "Compra en tienda WW", new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 540m, 123504, 10 },
                    { 50, "Compra en tienda XX", new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 550m, 123505, 10 },
                    { 51, "Compra en tienda YY", new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 560m, 123506, 11 },
                    { 52, "Compra en tienda ZZ", new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 570m, 123507, 11 },
                    { 53, "Compra en tienda AAA", new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 580m, 123508, 11 },
                    { 54, "Compra en tienda BBB", new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 590m, 123509, 11 },
                    { 55, "Compra en tienda CCC", new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 600m, 123510, 11 },
                    { 56, "Compra en tienda DDD", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 610m, 123511, 12 },
                    { 57, "Compra en tienda EEE", new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 620m, 123512, 12 },
                    { 58, "Compra en tienda FFF", new DateTime(2024, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 630m, 123513, 12 },
                    { 59, "Compra en tienda GGG", new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 640m, 123514, 12 },
                    { 60, "Compra en tienda HHH", new DateTime(2024, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 650m, 123515, 13 },
                    { 61, "Compra en tienda III", new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 660m, 123516, 13 },
                    { 62, "Compra en tienda JJJ", new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 670m, 123517, 13 },
                    { 63, "Compra en tienda KKK", new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 680m, 123518, 14 },
                    { 64, "Compra en tienda LLL", new DateTime(2024, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 690m, 123519, 14 },
                    { 65, "Compra en tienda MMM", new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 700m, 123520, 15 }
                });

            migrationBuilder.InsertData(
                table: "Pagos",
                columns: new[] { "Id", "Fecha", "Monto", "NumeroAutorizacion", "TarjetaCreditoId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 111111, 1 },
                    { 2, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 111112, 1 },
                    { 3, new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 60m, 111113, 2 },
                    { 4, new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 110m, 111114, 2 },
                    { 5, new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 111115, 3 },
                    { 6, new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, 111116, 3 },
                    { 7, new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 80m, 111117, 4 },
                    { 8, new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 130m, 111118, 4 },
                    { 9, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 90m, 111119, 5 },
                    { 10, new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 140m, 111120, 5 },
                    { 11, new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 111121, 6 },
                    { 12, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 150m, 111122, 6 },
                    { 13, new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 110m, 111123, 7 },
                    { 14, new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 160m, 111124, 7 },
                    { 15, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, 111125, 8 },
                    { 16, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, 111126, 8 },
                    { 17, new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 130m, 111127, 9 },
                    { 18, new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 180m, 111128, 9 },
                    { 19, new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 140m, 111129, 10 },
                    { 20, new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 190m, 111130, 10 },
                    { 21, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 150m, 111131, 11 },
                    { 22, new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 200m, 111132, 11 },
                    { 23, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 160m, 111133, 12 },
                    { 24, new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 210m, 111134, 12 },
                    { 25, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, 111135, 13 },
                    { 26, new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 220m, 111136, 13 },
                    { 27, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 180m, 111137, 14 },
                    { 28, new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 230m, 111138, 14 },
                    { 29, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 190m, 111139, 15 },
                    { 30, new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 240m, 111140, 15 }
                });

            migrationBuilder.InsertData(
                table: "Transacciones",
                columns: new[] { "Id", "Descripcion", "Fecha", "Monto", "NumeroAutorizacion", "TarjetaCreditoId", "TipoTransaccionId" },
                values: new object[,]
                {
                    { 1, "Pago de TC", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50m, 111111, 1, 2 },
                    { 2, "Pago de TC", new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 111112, 1, 2 },
                    { 3, "Pago de TC", new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 60m, 111113, 2, 2 },
                    { 4, "Pago de TC", new DateTime(2024, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 110m, 111114, 2, 2 },
                    { 5, "Pago de TC", new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 70m, 111115, 3, 2 },
                    { 6, "Pago de TC", new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, 111116, 3, 2 },
                    { 7, "Pago de TC", new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 80m, 111117, 4, 2 },
                    { 8, "Pago de TC", new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 130m, 111118, 4, 2 },
                    { 9, "Pago de TC", new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 90m, 111119, 5, 2 },
                    { 10, "Pago de TC", new DateTime(2024, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 140m, 111120, 5, 2 },
                    { 11, "Pago de TC", new DateTime(2024, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 111121, 6, 2 },
                    { 12, "Pago de TC", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 150m, 111122, 6, 2 },
                    { 13, "Pago de TC", new DateTime(2024, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 110m, 111123, 7, 2 },
                    { 14, "Pago de TC", new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 160m, 111124, 7, 2 },
                    { 15, "Pago de TC", new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, 111125, 8, 2 },
                    { 16, "Pago de TC", new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, 111126, 8, 2 },
                    { 17, "Pago de TC", new DateTime(2024, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 130m, 111127, 9, 2 },
                    { 18, "Pago de TC", new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 180m, 111128, 9, 2 },
                    { 19, "Pago de TC", new DateTime(2024, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 140m, 111129, 10, 2 },
                    { 20, "Pago de TC", new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 190m, 111130, 10, 2 },
                    { 21, "Pago de TC", new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 150m, 111131, 11, 2 },
                    { 22, "Pago de TC", new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 200m, 111132, 11, 2 },
                    { 23, "Pago de TC", new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 160m, 111133, 12, 2 },
                    { 24, "Pago de TC", new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 210m, 111134, 12, 2 },
                    { 25, "Pago de TC", new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, 111135, 13, 2 },
                    { 26, "Pago de TC", new DateTime(2024, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 220m, 111136, 13, 2 },
                    { 27, "Pago de TC", new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 180m, 111137, 14, 2 },
                    { 28, "Pago de TC", new DateTime(2024, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 230m, 111138, 14, 2 },
                    { 29, "Pago de TC", new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 190m, 111139, 15, 2 },
                    { 30, "Pago de TC", new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 240m, 111140, 15, 2 },
                    { 31, "Compra en tienda A", new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 100m, 123456, 1, 1 },
                    { 32, "Compra en tienda B", new DateTime(2024, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 150m, 123457, 1, 1 },
                    { 33, "Compra en tienda C", new DateTime(2024, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 200m, 123458, 1, 1 },
                    { 34, "Compra en tienda D", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 250m, 123459, 1, 1 },
                    { 35, "Compra en tienda E", new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, 123460, 1, 1 },
                    { 36, "Compra en tienda F", new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 110m, 123461, 2, 1 },
                    { 37, "Compra en tienda G", new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 120m, 123462, 2, 1 },
                    { 38, "Compra en tienda H", new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 130m, 123463, 2, 1 },
                    { 39, "Compra en tienda I", new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 140m, 123464, 2, 1 },
                    { 40, "Compra en tienda J", new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 150m, 123465, 2, 1 },
                    { 41, "Compra en tienda K", new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 160m, 123466, 3, 1 },
                    { 42, "Compra en tienda L", new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 170m, 123467, 3, 1 },
                    { 43, "Compra en tienda M", new DateTime(2024, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 180m, 123468, 3, 1 },
                    { 44, "Compra en tienda N", new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 190m, 123469, 3, 1 },
                    { 45, "Compra en tienda O", new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 200m, 123470, 3, 1 },
                    { 46, "Compra en tienda P", new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 210m, 123471, 4, 1 },
                    { 47, "Compra en tienda Q", new DateTime(2024, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 220m, 123472, 4, 1 },
                    { 48, "Compra en tienda R", new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 230m, 123473, 4, 1 },
                    { 49, "Compra en tienda S", new DateTime(2024, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 240m, 123474, 4, 1 },
                    { 50, "Compra en tienda T", new DateTime(2024, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 250m, 123475, 4, 1 },
                    { 51, "Compra en tienda U", new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 260m, 123476, 5, 1 },
                    { 52, "Compra en tienda V", new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 270m, 123477, 5, 1 },
                    { 53, "Compra en tienda W", new DateTime(2024, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 280m, 123478, 5, 1 },
                    { 54, "Compra en tienda X", new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 290m, 123479, 5, 1 },
                    { 55, "Compra en tienda Y", new DateTime(2024, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 300m, 123480, 5, 1 },
                    { 56, "Compra en tienda Z", new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 310m, 123481, 6, 1 },
                    { 57, "Compra en tienda AA", new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 320m, 123482, 6, 1 },
                    { 58, "Compra en tienda BB", new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 330m, 123483, 6, 1 },
                    { 59, "Compra en tienda CC", new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 340m, 123484, 6, 1 },
                    { 60, "Compra en tienda DD", new DateTime(2024, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 350m, 123485, 6, 1 },
                    { 61, "Compra en tienda EE", new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 360m, 123486, 7, 1 },
                    { 62, "Compra en tienda FF", new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 370m, 123487, 7, 1 },
                    { 63, "Compra en tienda GG", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 380m, 123488, 7, 1 },
                    { 64, "Compra en tienda HH", new DateTime(2024, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 390m, 123489, 7, 1 },
                    { 65, "Compra en tienda II", new DateTime(2024, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 400m, 123490, 7, 1 },
                    { 66, "Compra en tienda JJ", new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 410m, 123491, 8, 1 },
                    { 67, "Compra en tienda KK", new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 420m, 123492, 8, 1 },
                    { 68, "Compra en tienda LL", new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 430m, 123493, 8, 1 },
                    { 69, "Compra en tienda MM", new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 440m, 123494, 8, 1 },
                    { 70, "Compra en tienda NN", new DateTime(2024, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 450m, 123495, 8, 1 },
                    { 71, "Compra en tienda OO", new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 460m, 123496, 9, 1 },
                    { 72, "Compra en tienda PP", new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 470m, 123497, 9, 1 },
                    { 73, "Compra en tienda QQ", new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 480m, 123498, 9, 1 },
                    { 74, "Compra en tienda RR", new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 490m, 123499, 9, 1 },
                    { 75, "Compra en tienda SS", new DateTime(2024, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m, 123500, 9, 1 },
                    { 76, "Compra en tienda TT", new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 510m, 123501, 10, 1 },
                    { 77, "Compra en tienda UU", new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 520m, 123502, 10, 1 },
                    { 78, "Compra en tienda VV", new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 530m, 123503, 10, 1 },
                    { 79, "Compra en tienda WW", new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 540m, 123504, 10, 1 },
                    { 80, "Compra en tienda XX", new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 550m, 123505, 10, 1 },
                    { 81, "Compra en tienda YY", new DateTime(2024, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 560m, 123506, 11, 1 },
                    { 82, "Compra en tienda ZZ", new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 570m, 123507, 11, 1 },
                    { 83, "Compra en tienda AAA", new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 580m, 123508, 11, 1 },
                    { 84, "Compra en tienda BBB", new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 590m, 123509, 11, 1 },
                    { 85, "Compra en tienda CCC", new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 600m, 123510, 11, 1 },
                    { 86, "Compra en tienda DDD", new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 610m, 123511, 12, 1 },
                    { 87, "Compra en tienda EEE", new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 620m, 123512, 12, 1 },
                    { 88, "Compra en tienda FFF", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 630m, 123513, 12, 1 },
                    { 89, "Compra en tienda GGG", new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 640m, 123514, 12, 1 },
                    { 90, "Compra en tienda HHH", new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 650m, 123515, 12, 1 },
                    { 91, "Compra en tienda III", new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 660m, 123516, 13, 1 },
                    { 92, "Compra en tienda JJJ", new DateTime(2024, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 670m, 123517, 13, 1 },
                    { 93, "Compra en tienda KKK", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 680m, 123518, 13, 1 },
                    { 94, "Compra en tienda LLL", new DateTime(2024, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 690m, 123519, 13, 1 },
                    { 95, "Compra en tienda MMM", new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 700m, 123520, 13, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Transacciones",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TarjetasCredito",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Pérez", "Juan" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "García", "María" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Martínez", "Roberto" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Rodríguez", "Ana" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "López", "Carlos" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Fernández", "Laura" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Sánchez", "Jorge" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Ramírez", "Sofía" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Gómez", "Diego" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Díaz", "Valeria" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Vargas", "Eduardo" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Castro", "Paola" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Morales", "Alejandro" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Herrera", "Adriana" });

            migrationBuilder.UpdateData(
                table: "Titulares",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Apellidos", "Nombre" },
                values: new object[] { "Núñez", "Guillermo" });
        }
    }
}
