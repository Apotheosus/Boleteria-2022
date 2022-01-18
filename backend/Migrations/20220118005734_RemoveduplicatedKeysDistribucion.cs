using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoleteriaOnline.Web.Migrations
{
    public partial class RemoveduplicatedKeysDistribucion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_filas_distribuciones_distribucion_id1",
                table: "filas");

            migrationBuilder.DropForeignKey(
                name: "fk_filas_distribuciones_distribucion_id2",
                table: "filas");

            migrationBuilder.DropIndex(
                name: "ix_filas_distribucion_id1",
                table: "filas");

            migrationBuilder.DropIndex(
                name: "ix_filas_distribucion_id2",
                table: "filas");

            migrationBuilder.DropColumn(
                name: "distribucion_id1",
                table: "filas");

            migrationBuilder.DropColumn(
                name: "distribucion_id2",
                table: "filas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "distribucion_id1",
                table: "filas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "distribucion_id2",
                table: "filas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_filas_distribucion_id1",
                table: "filas",
                column: "distribucion_id1");

            migrationBuilder.CreateIndex(
                name: "ix_filas_distribucion_id2",
                table: "filas",
                column: "distribucion_id2");

            migrationBuilder.AddForeignKey(
                name: "fk_filas_distribuciones_distribucion_id1",
                table: "filas",
                column: "distribucion_id1",
                principalTable: "distribuciones",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_filas_distribuciones_distribucion_id2",
                table: "filas",
                column: "distribucion_id2",
                principalTable: "distribuciones",
                principalColumn: "id");
        }
    }
}
