using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoleteriaOnline.Web.Migrations
{
    public partial class DestinoEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "distribucion_id2",
                table: "filas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "planta",
                table: "filas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "destinos",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "destinos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "estado",
                table: "destinos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "destinos",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "ix_filas_distribucion_id2",
                table: "filas",
                column: "distribucion_id2");

            migrationBuilder.CreateIndex(
                name: "ix_destinos_nombre",
                table: "destinos",
                column: "nombre",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "fk_filas_distribuciones_distribucion_id2",
                table: "filas",
                column: "distribucion_id2",
                principalTable: "distribuciones",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_filas_distribuciones_distribucion_id2",
                table: "filas");

            migrationBuilder.DropIndex(
                name: "ix_filas_distribucion_id2",
                table: "filas");

            migrationBuilder.DropIndex(
                name: "ix_destinos_nombre",
                table: "destinos");

            migrationBuilder.DropColumn(
                name: "distribucion_id2",
                table: "filas");

            migrationBuilder.DropColumn(
                name: "planta",
                table: "filas");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "destinos");

            migrationBuilder.DropColumn(
                name: "estado",
                table: "destinos");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "destinos");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "destinos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
