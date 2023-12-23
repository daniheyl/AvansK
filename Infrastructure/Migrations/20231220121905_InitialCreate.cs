using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodPackages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodPackages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContainsAlcohol = table.Column<bool>(type: "bit", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodPackageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_FoodPackages_FoodPackageId",
                        column: x => x.FoodPackageId,
                        principalTable: "FoodPackages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PackageDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodPackageId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PackageDetail_FoodPackages_FoodPackageId",
                        column: x => x.FoodPackageId,
                        principalTable: "FoodPackages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackageDetail_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FoodPackages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "pakket 1" },
                    { 2, "pakket 2" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ContainsAlcohol", "FoodPackageId", "Name", "Picture" },
                values: new object[,]
                {
                    { 1, false, null, "Hamburger", "NA" },
                    { 2, true, null, "Bier", "NA" },
                    { 3, false, null, "Danoontje", "NA" }
                });

            migrationBuilder.InsertData(
                table: "PackageDetail",
                columns: new[] { "Id", "FoodPackageId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PackageDetail_FoodPackageId",
                table: "PackageDetail",
                column: "FoodPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_PackageDetail_ProductId",
                table: "PackageDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_FoodPackageId",
                table: "Products",
                column: "FoodPackageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PackageDetail");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "FoodPackages");
        }
    }
}
