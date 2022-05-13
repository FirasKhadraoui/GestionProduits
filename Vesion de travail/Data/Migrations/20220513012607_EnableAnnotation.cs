using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class EnableAnnotation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "TestUpdate",
                table: "Products",
                newName: "Image");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Products",
                newName: "TestUpdate");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
