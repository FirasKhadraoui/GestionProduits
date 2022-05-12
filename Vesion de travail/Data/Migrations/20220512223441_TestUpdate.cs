using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class TestUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TestUpdate",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestUpdate",
                table: "Products");
        }
    }
}
