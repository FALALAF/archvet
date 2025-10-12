using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class InitPostgres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SlownikPlec",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nazwa = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SlownikPlec", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "osoba",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nazwisko = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    plec_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_osoba", x => x.id);
                    table.ForeignKey(
                        name: "FK_osoba_SlownikPlec_plec_id",
                        column: x => x.plec_id,
                        principalTable: "SlownikPlec",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SlownikPlec",
                columns: new[] { "Id", "Nazwa" },
                values: new object[,]
                {
                    { 1, "Mężczyzna" },
                    { 2, "Kobieta" },
                    { 3, "Inna" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_osoba_plec_id",
                table: "osoba",
                column: "plec_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "osoba");

            migrationBuilder.DropTable(
                name: "SlownikPlec");
        }
    }
}
