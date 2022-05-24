using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Viaggiatore.Migrations
{
    public partial class tabellaRichiestaUtenti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "richiestaUtenteId",
                table: "pacchetti",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "richiesteUtenti",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    cognome = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    email = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    messaggio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_richiesteUtenti", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pacchetti_richiestaUtenteId",
                table: "pacchetti",
                column: "richiestaUtenteId");

            migrationBuilder.AddForeignKey(
                name: "FK_pacchetti_richiesteUtenti_richiestaUtenteId",
                table: "pacchetti",
                column: "richiestaUtenteId",
                principalTable: "richiesteUtenti",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pacchetti_richiesteUtenti_richiestaUtenteId",
                table: "pacchetti");

            migrationBuilder.DropTable(
                name: "richiesteUtenti");

            migrationBuilder.DropIndex(
                name: "IX_pacchetti_richiestaUtenteId",
                table: "pacchetti");

            migrationBuilder.DropColumn(
                name: "richiestaUtenteId",
                table: "pacchetti");
        }
    }
}
