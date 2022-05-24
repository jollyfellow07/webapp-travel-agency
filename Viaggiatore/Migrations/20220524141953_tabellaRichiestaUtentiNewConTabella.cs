using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Viaggiatore.Migrations
{
    public partial class tabellaRichiestaUtentiNewConTabella : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pacchetti_richiesteUtenti_richiestaUtenteId",
                table: "pacchetti");

            migrationBuilder.DropIndex(
                name: "IX_pacchetti_richiestaUtenteId",
                table: "pacchetti");

            migrationBuilder.DropColumn(
                name: "messaggio",
                table: "richiesteUtenti");

            migrationBuilder.DropColumn(
                name: "richiestaUtenteId",
                table: "pacchetti");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "richiesteUtenti",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "richiesteUtenti",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "cognome",
                table: "richiesteUtenti",
                newName: "Cognome");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "richiesteUtenti",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "richiesteUtenti",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "richiesteUtenti",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Cognome",
                table: "richiesteUtenti",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<int>(
                name: "PacchettoId",
                table: "richiesteUtenti",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Telefono",
                table: "richiesteUtenti",
                type: "int",
                maxLength: 75,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Testo",
                table: "richiesteUtenti",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_richiesteUtenti_PacchettoId",
                table: "richiesteUtenti",
                column: "PacchettoId");

            migrationBuilder.AddForeignKey(
                name: "FK_richiesteUtenti_pacchetti_PacchettoId",
                table: "richiesteUtenti",
                column: "PacchettoId",
                principalTable: "pacchetti",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_richiesteUtenti_pacchetti_PacchettoId",
                table: "richiesteUtenti");

            migrationBuilder.DropIndex(
                name: "IX_richiesteUtenti_PacchettoId",
                table: "richiesteUtenti");

            migrationBuilder.DropColumn(
                name: "PacchettoId",
                table: "richiesteUtenti");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "richiesteUtenti");

            migrationBuilder.DropColumn(
                name: "Testo",
                table: "richiesteUtenti");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "richiesteUtenti",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "richiesteUtenti",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Cognome",
                table: "richiesteUtenti",
                newName: "cognome");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "richiesteUtenti",
                newName: "id");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "richiesteUtenti",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldMaxLength: 75);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "richiesteUtenti",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldMaxLength: 75);

            migrationBuilder.AlterColumn<string>(
                name: "cognome",
                table: "richiesteUtenti",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldMaxLength: 75);

            migrationBuilder.AddColumn<string>(
                name: "messaggio",
                table: "richiesteUtenti",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "richiestaUtenteId",
                table: "pacchetti",
                type: "int",
                nullable: true);

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
    }
}
