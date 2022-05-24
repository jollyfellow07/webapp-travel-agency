using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Viaggiatore.Migrations
{
    public partial class tabellaRichiestaUtentiNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pacchetti",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titolo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    descrizione = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    immagine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezzo = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pacchetti", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pacchetti");
        }
    }
}
