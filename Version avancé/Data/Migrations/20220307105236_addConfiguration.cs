using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class addConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_products_productsproductid",
                table: "ProductProvider");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Providers_ProvidersId",
                table: "ProductProvider");

            migrationBuilder.DropForeignKey(
                name: "FK_products_Categories_CategoryId",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductProvider",
                table: "ProductProvider");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "products");

            migrationBuilder.RenameTable(
                name: "ProductProvider",
                newName: "Providings");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "MyCategories");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "products",
                newName: "MyName");

            migrationBuilder.RenameColumn(
                name: "MyAdress_StreetAdress",
                table: "products",
                newName: "MyStreet");

            migrationBuilder.RenameColumn(
                name: "MyAdress_City",
                table: "products",
                newName: "MyCity");

            migrationBuilder.RenameIndex(
                name: "IX_ProductProvider_productsproductid",
                table: "Providings",
                newName: "IX_Providings_productsproductid");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "products",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MyStreet",
                table: "products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsBiological",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "MyCategories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Providings",
                table: "Providings",
                columns: new[] { "ProvidersId", "productsproductid" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyCategories",
                table: "MyCategories",
                column: "CategorieId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_MyCategories_CategoryId",
                table: "products",
                column: "CategoryId",
                principalTable: "MyCategories",
                principalColumn: "CategorieId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Providings_products_productsproductid",
                table: "Providings",
                column: "productsproductid",
                principalTable: "products",
                principalColumn: "productid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Providings_Providers_ProvidersId",
                table: "Providings",
                column: "ProvidersId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_MyCategories_CategoryId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_Providings_products_productsproductid",
                table: "Providings");

            migrationBuilder.DropForeignKey(
                name: "FK_Providings_Providers_ProvidersId",
                table: "Providings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Providings",
                table: "Providings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyCategories",
                table: "MyCategories");

            migrationBuilder.DropColumn(
                name: "IsBiological",
                table: "products");

            migrationBuilder.RenameTable(
                name: "Providings",
                newName: "ProductProvider");

            migrationBuilder.RenameTable(
                name: "MyCategories",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "MyStreet",
                table: "products",
                newName: "MyAdress_StreetAdress");

            migrationBuilder.RenameColumn(
                name: "MyName",
                table: "products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "MyCity",
                table: "products",
                newName: "MyAdress_City");

            migrationBuilder.RenameIndex(
                name: "IX_Providings_productsproductid",
                table: "ProductProvider",
                newName: "IX_ProductProvider_productsproductid");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MyAdress_StreetAdress",
                table: "products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductProvider",
                table: "ProductProvider",
                columns: new[] { "ProvidersId", "productsproductid" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategorieId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_products_productsproductid",
                table: "ProductProvider",
                column: "productsproductid",
                principalTable: "products",
                principalColumn: "productid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Providers_ProvidersId",
                table: "ProductProvider",
                column: "ProvidersId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_Categories_CategoryId",
                table: "products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategorieId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
