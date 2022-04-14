using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class AddOwnedType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StreetAdress",
                table: "products",
                newName: "MyAdress_StreetAdress");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "products",
                newName: "MyAdress_City");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyAdress_StreetAdress",
                table: "products",
                newName: "StreetAdress");

            migrationBuilder.RenameColumn(
                name: "MyAdress_City",
                table: "products",
                newName: "City");
        }
    }
}
