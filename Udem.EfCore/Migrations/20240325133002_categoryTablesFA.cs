using Microsoft.EntityFrameworkCore.Migrations;

namespace Udem.EfCore.Migrations
{
    public partial class categoryTablesFA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys");

            migrationBuilder.EnsureSchema(
                name: "ft");

            migrationBuilder.RenameTable(
                name: "Categorys",
                newName: "Categories",
                newSchema: "ft");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                schema: "ft",
                table: "Categories",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                schema: "ft",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                schema: "ft",
                newName: "Categorys");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys",
                column: "Id");
        }
    }
}
