using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoleteriaOnline.Web.Migrations
{
    public partial class RemoveEstadoFromDestino : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_celdas_filas_fila_id",
                table: "celdas");

            migrationBuilder.DropForeignKey(
                name: "fk_filas_distribuciones_distribucion_id",
                table: "filas");

            migrationBuilder.DropForeignKey(
                name: "fk_horarios_filas_frecuencia_id",
                table: "horarios");

            migrationBuilder.DropIndex(
                name: "ix_horarios_frecuencia_id",
                table: "horarios");

            migrationBuilder.DropColumn(
                name: "frecuencia_id",
                table: "horarios");

            migrationBuilder.DropColumn(
                name: "estado",
                table: "destinos");

            migrationBuilder.AddColumn<bool>(
                name: "domingo",
                table: "horarios",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "jueves",
                table: "horarios",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "lunes",
                table: "horarios",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "martes",
                table: "horarios",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "miercoles",
                table: "horarios",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "sabado",
                table: "horarios",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "viernes",
                table: "horarios",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "distribucion_id",
                table: "filas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "fila_id",
                table: "celdas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "fk_celdas_filas_fila_id",
                table: "celdas",
                column: "fila_id",
                principalTable: "filas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_filas_distribuciones_distribucion_id",
                table: "filas",
                column: "distribucion_id",
                principalTable: "distribuciones",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_celdas_filas_fila_id",
                table: "celdas");

            migrationBuilder.DropForeignKey(
                name: "fk_filas_distribuciones_distribucion_id",
                table: "filas");

            migrationBuilder.DropColumn(
                name: "domingo",
                table: "horarios");

            migrationBuilder.DropColumn(
                name: "jueves",
                table: "horarios");

            migrationBuilder.DropColumn(
                name: "lunes",
                table: "horarios");

            migrationBuilder.DropColumn(
                name: "martes",
                table: "horarios");

            migrationBuilder.DropColumn(
                name: "miercoles",
                table: "horarios");

            migrationBuilder.DropColumn(
                name: "sabado",
                table: "horarios");

            migrationBuilder.DropColumn(
                name: "viernes",
                table: "horarios");

            migrationBuilder.AddColumn<int>(
                name: "frecuencia_id",
                table: "horarios",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "distribucion_id",
                table: "filas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "estado",
                table: "destinos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "fila_id",
                table: "celdas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "ix_horarios_frecuencia_id",
                table: "horarios",
                column: "frecuencia_id");

            migrationBuilder.AddForeignKey(
                name: "fk_celdas_filas_fila_id",
                table: "celdas",
                column: "fila_id",
                principalTable: "filas",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_filas_distribuciones_distribucion_id",
                table: "filas",
                column: "distribucion_id",
                principalTable: "distribuciones",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_horarios_filas_frecuencia_id",
                table: "horarios",
                column: "frecuencia_id",
                principalTable: "filas",
                principalColumn: "id");
        }
    }
}
