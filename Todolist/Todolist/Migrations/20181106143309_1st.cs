using Microsoft.EntityFrameworkCore.Migrations;

namespace Todolist.Migrations
{
    public partial class _1st : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prio",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "Skip",
                table: "Item",
                newName: "Verschoben");

            migrationBuilder.RenameColumn(
                name: "Done",
                table: "Item",
                newName: "Erledigt");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Item",
                newName: "Aufgabe");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Item",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "Priorität",
                table: "Item",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Priorität",
                table: "Item");

            migrationBuilder.RenameColumn(
                name: "Verschoben",
                table: "Item",
                newName: "Skip");

            migrationBuilder.RenameColumn(
                name: "Erledigt",
                table: "Item",
                newName: "Done");

            migrationBuilder.RenameColumn(
                name: "Aufgabe",
                table: "Item",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Item",
                newName: "ItemId");

            migrationBuilder.AddColumn<int>(
                name: "Prio",
                table: "Item",
                nullable: false,
                defaultValue: 0);
        }
    }
}
