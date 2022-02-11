using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoleteriaOnline.Web.Migrations
{
    public partial class ViajeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_horarios_distribuciones_distribucion_id",
                table: "horarios");

            migrationBuilder.DropIndex(
                name: "ix_horarios_distribucion_id",
                table: "horarios");

            migrationBuilder.AlterColumn<int>(
                name: "distribucion_id",
                table: "horarios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_viajes_nombre",
                table: "viajes",
                column: "nombre",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_viajes_nombre",
                table: "viajes");

            migrationBuilder.AlterColumn<int>(
                name: "distribucion_id",
                table: "horarios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "ix_horarios_distribucion_id",
                table: "horarios",
                column: "distribucion_id");

            migrationBuilder.AddForeignKey(
                name: "fk_horarios_distribuciones_distribucion_id",
                table: "horarios",
                column: "distribucion_id",
                principalTable: "distribuciones",
                principalColumn: "id");
        }
    }
}
