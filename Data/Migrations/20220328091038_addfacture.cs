using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class addfacture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    CIN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_naissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.CIN);
                });

            migrationBuilder.CreateTable(
                name: "Facture",
                columns: table => new
                {
                    clientFK = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_achat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    prix = table.Column<double>(type: "float", nullable: false),
                    productFK = table.Column<int>(type: "int", nullable: false),
                    clientCIN = table.Column<int>(type: "int", nullable: true),
                    productid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facture", x => x.clientFK);
                    table.ForeignKey(
                        name: "FK_Facture_Client_clientCIN",
                        column: x => x.clientCIN,
                        principalTable: "Client",
                        principalColumn: "CIN",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facture_products_productid",
                        column: x => x.productid,
                        principalTable: "products",
                        principalColumn: "productid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Facture_clientCIN",
                table: "Facture",
                column: "clientCIN");

            migrationBuilder.CreateIndex(
                name: "IX_Facture_productid",
                table: "Facture",
                column: "productid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facture");

            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
