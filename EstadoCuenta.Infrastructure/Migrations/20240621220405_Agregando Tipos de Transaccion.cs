using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstadoCuenta.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AgregandoTiposdeTransaccion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoTransaccion",
                table: "Transacciones");

            migrationBuilder.RenameColumn(
                name: "PorcentajeInteresConfigurable",
                table: "TarjetasCredito",
                newName: "PorcentajeSaldoMinimo");

            migrationBuilder.RenameColumn(
                name: "PorcentajeConfigurableSaldoMinimo",
                table: "TarjetasCredito",
                newName: "PorcentajeInteres");

            migrationBuilder.AddColumn<int>(
                name: "TipoTransaccionId",
                table: "Transacciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TipoTransaccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTransaccion", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transacciones_TipoTransaccionId",
                table: "Transacciones",
                column: "TipoTransaccionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transacciones_TipoTransaccion_TipoTransaccionId",
                table: "Transacciones",
                column: "TipoTransaccionId",
                principalTable: "TipoTransaccion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transacciones_TipoTransaccion_TipoTransaccionId",
                table: "Transacciones");

            migrationBuilder.DropTable(
                name: "TipoTransaccion");

            migrationBuilder.DropIndex(
                name: "IX_Transacciones_TipoTransaccionId",
                table: "Transacciones");

            migrationBuilder.DropColumn(
                name: "TipoTransaccionId",
                table: "Transacciones");

            migrationBuilder.RenameColumn(
                name: "PorcentajeSaldoMinimo",
                table: "TarjetasCredito",
                newName: "PorcentajeInteresConfigurable");

            migrationBuilder.RenameColumn(
                name: "PorcentajeInteres",
                table: "TarjetasCredito",
                newName: "PorcentajeConfigurableSaldoMinimo");

            migrationBuilder.AddColumn<string>(
                name: "TipoTransaccion",
                table: "Transacciones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
