using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstadoCuenta.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoCampoAutorizacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumeroAutorizacion",
                table: "Transacciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumeroAutorizacion",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumeroAutorizacion",
                table: "Compras",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroAutorizacion",
                table: "Transacciones");

            migrationBuilder.DropColumn(
                name: "NumeroAutorizacion",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "NumeroAutorizacion",
                table: "Compras");
        }
    }
}
