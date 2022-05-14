using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class addTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Products_ProductsProductId",
                table: "ProductProvider");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductProvider_Providers_ProvidersId",
                table: "ProductProvider");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductProvider",
                table: "ProductProvider");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "ProductProvider",
                newName: "Providings");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "MyCategories");

            migrationBuilder.RenameColumn(
                name: "Myadress_StreetAdress",
                table: "Products",
                newName: "MyStreet");

            migrationBuilder.RenameColumn(
                name: "Myadress_City",
                table: "Products",
                newName: "MyCity");

            migrationBuilder.RenameColumn(
                name: "MyName",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_ProductProvider_ProvidersId",
                table: "Providings",
                newName: "IX_Providings_ProvidersId");

            migrationBuilder.RenameColumn(
                name: "MyName",
                table: "MyCategories",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "MyStreet",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "isBiological",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
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
                columns: new[] { "ProductsProductId", "ProvidersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyCategories",
                table: "MyCategories",
                column: "CategoryId");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Cin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Cin);
                });

            migrationBuilder.CreateTable(
                name: "Factures",
                columns: table => new
                {
                    ProductFk = table.Column<int>(type: "int", nullable: false),
                    ClientFk = table.Column<int>(type: "int", nullable: false),
                    DateAchat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    prix = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factures", x => new { x.ProductFk, x.ClientFk, x.DateAchat });
                    table.ForeignKey(
                        name: "FK_Factures_Clients_ClientFk",
                        column: x => x.ClientFk,
                        principalTable: "Clients",
                        principalColumn: "Cin",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Factures_Products_ProductFk",
                        column: x => x.ProductFk,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Factures_ClientFk",
                table: "Factures",
                column: "ClientFk");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MyCategories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "MyCategories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Providings_Products_ProductsProductId",
                table: "Providings",
                column: "ProductsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
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
                name: "FK_Products_MyCategories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Providings_Products_ProductsProductId",
                table: "Providings");

            migrationBuilder.DropForeignKey(
                name: "FK_Providings_Providers_ProvidersId",
                table: "Providings");

            migrationBuilder.DropTable(
                name: "Factures");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Providings",
                table: "Providings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyCategories",
                table: "MyCategories");

            migrationBuilder.DropColumn(
                name: "isBiological",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Providings",
                newName: "ProductProvider");

            migrationBuilder.RenameTable(
                name: "MyCategories",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "MyName");

            migrationBuilder.RenameColumn(
                name: "MyStreet",
                table: "Products",
                newName: "Myadress_StreetAdress");

            migrationBuilder.RenameColumn(
                name: "MyCity",
                table: "Products",
                newName: "Myadress_City");

            migrationBuilder.RenameIndex(
                name: "IX_Providings_ProvidersId",
                table: "ProductProvider",
                newName: "IX_ProductProvider_ProvidersId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "MyName");

            migrationBuilder.AlterColumn<string>(
                name: "Myadress_StreetAdress",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "MyName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductProvider",
                table: "ProductProvider",
                columns: new[] { "ProductsProductId", "ProvidersId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Products_ProductsProductId",
                table: "ProductProvider",
                column: "ProductsProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProvider_Providers_ProvidersId",
                table: "ProductProvider",
                column: "ProvidersId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
