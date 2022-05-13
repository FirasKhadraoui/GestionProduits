using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class FluentAp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "MyName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "MyName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyName",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MyName",
                table: "Categories",
                newName: "Name");
        }
    }
}
