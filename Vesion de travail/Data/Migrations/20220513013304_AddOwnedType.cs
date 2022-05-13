using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddOwnedType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StreetAddress",
                table: "Products",
                newName: "Myadress_StreetAdress");

            migrationBuilder.AddColumn<string>(
                name: "Myadress_City",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Myadress_City",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Myadress_StreetAdress",
                table: "Products",
                newName: "StreetAddress");
        }
    }
}
