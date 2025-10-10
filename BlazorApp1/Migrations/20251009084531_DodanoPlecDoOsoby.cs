using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class DodanoPlecDoOsoby : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "plec_id",
                table: "osoba",
                type: "int",
                nullable: false,
                defaultValue: 3);

            migrationBuilder.CreateIndex(
                name: "IX_osoba_plec_id",
                table: "osoba",
                column: "plec_id");

            migrationBuilder.AddForeignKey(
                name: "FK_osoba_SlownikPlec_plec_id",
                table: "osoba",
                column: "plec_id",
                principalTable: "SlownikPlec",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_osoba_SlownikPlec_plec_id",
                table: "osoba");

            migrationBuilder.DropIndex(
                name: "IX_osoba_plec_id",
                table: "osoba");

            migrationBuilder.DropColumn(
                name: "plec_id",
                table: "osoba");
        }
    }
}
