using Microsoft.EntityFrameworkCore.Migrations;

namespace Udem.EfCore.Migrations
{
    public partial class snakecaseFA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                schema: "ft",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                schema: "ft",
                newName: "Categorys");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "product_name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Products",
                newName: "product_id");

            migrationBuilder.AlterColumn<string>(
                name: "product_name",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categorys",
                table: "Categorys",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "product_name",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "Products",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                schema: "ft",
                table: "Categories",
                column: "Id");
        }
    }
}
