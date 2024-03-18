using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Presentacion.API.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contribuyentes",
                columns: table => new
                {
                    rncCedula = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    tipo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    estatus = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Contribu__38AA49B3ED6E0A8E", x => x.rncCedula);
                });

            migrationBuilder.CreateTable(
                name: "ComprobantesFiscales",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rncCedula = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    NCF = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    monto = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    itbis18 = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Comproba__3213E83FEF07087D", x => x.id);
                    table.ForeignKey(
                        name: "FK__Comproban__rncCe__4BAC3F29",
                        column: x => x.rncCedula,
                        principalTable: "Contribuyentes",
                        principalColumn: "rncCedula");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComprobantesFiscales_rncCedula",
                table: "ComprobantesFiscales",
                column: "rncCedula");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComprobantesFiscales");

            migrationBuilder.DropTable(
                name: "Contribuyentes");
        }
    }
}
