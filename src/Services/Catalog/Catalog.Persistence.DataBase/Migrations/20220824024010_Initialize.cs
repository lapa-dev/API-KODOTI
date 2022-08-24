using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.DataBase.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "Catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                schema: "Catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "Catalog",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Description product 1", "Product 1", 271m },
                    { 72, "Description product 72", "Product 72", 421m },
                    { 71, "Description product 71", "Product 71", 405m },
                    { 70, "Description product 70", "Product 70", 827m },
                    { 69, "Description product 69", "Product 69", 590m },
                    { 68, "Description product 68", "Product 68", 178m },
                    { 67, "Description product 67", "Product 67", 973m },
                    { 66, "Description product 66", "Product 66", 177m },
                    { 65, "Description product 65", "Product 65", 542m },
                    { 64, "Description product 64", "Product 64", 456m },
                    { 63, "Description product 63", "Product 63", 811m },
                    { 62, "Description product 62", "Product 62", 774m },
                    { 61, "Description product 61", "Product 61", 539m },
                    { 60, "Description product 60", "Product 60", 496m },
                    { 59, "Description product 59", "Product 59", 348m },
                    { 58, "Description product 58", "Product 58", 372m },
                    { 57, "Description product 57", "Product 57", 605m },
                    { 56, "Description product 56", "Product 56", 683m },
                    { 55, "Description product 55", "Product 55", 845m },
                    { 54, "Description product 54", "Product 54", 299m },
                    { 53, "Description product 53", "Product 53", 912m },
                    { 52, "Description product 52", "Product 52", 598m },
                    { 73, "Description product 73", "Product 73", 501m },
                    { 51, "Description product 51", "Product 51", 921m },
                    { 74, "Description product 74", "Product 74", 281m },
                    { 76, "Description product 76", "Product 76", 840m },
                    { 97, "Description product 97", "Product 97", 855m },
                    { 96, "Description product 96", "Product 96", 733m },
                    { 95, "Description product 95", "Product 95", 587m },
                    { 94, "Description product 94", "Product 94", 332m },
                    { 93, "Description product 93", "Product 93", 742m },
                    { 92, "Description product 92", "Product 92", 419m },
                    { 91, "Description product 91", "Product 91", 992m },
                    { 90, "Description product 90", "Product 90", 129m },
                    { 89, "Description product 89", "Product 89", 276m },
                    { 88, "Description product 88", "Product 88", 680m },
                    { 87, "Description product 87", "Product 87", 224m },
                    { 86, "Description product 86", "Product 86", 252m },
                    { 85, "Description product 85", "Product 85", 593m },
                    { 84, "Description product 84", "Product 84", 820m },
                    { 83, "Description product 83", "Product 83", 857m },
                    { 82, "Description product 82", "Product 82", 621m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 81, "Description product 81", "Product 81", 985m },
                    { 80, "Description product 80", "Product 80", 577m },
                    { 79, "Description product 79", "Product 79", 935m },
                    { 78, "Description product 78", "Product 78", 208m },
                    { 77, "Description product 77", "Product 77", 215m },
                    { 75, "Description product 75", "Product 75", 695m },
                    { 98, "Description product 98", "Product 98", 117m },
                    { 50, "Description product 50", "Product 50", 390m },
                    { 48, "Description product 48", "Product 48", 155m },
                    { 22, "Description product 22", "Product 22", 588m },
                    { 21, "Description product 21", "Product 21", 507m },
                    { 20, "Description product 20", "Product 20", 203m },
                    { 19, "Description product 19", "Product 19", 308m },
                    { 18, "Description product 18", "Product 18", 231m },
                    { 17, "Description product 17", "Product 17", 412m },
                    { 16, "Description product 16", "Product 16", 998m },
                    { 15, "Description product 15", "Product 15", 425m },
                    { 14, "Description product 14", "Product 14", 303m },
                    { 13, "Description product 13", "Product 13", 200m },
                    { 12, "Description product 12", "Product 12", 853m },
                    { 11, "Description product 11", "Product 11", 214m },
                    { 10, "Description product 10", "Product 10", 292m },
                    { 9, "Description product 9", "Product 9", 871m },
                    { 8, "Description product 8", "Product 8", 922m },
                    { 7, "Description product 7", "Product 7", 355m },
                    { 6, "Description product 6", "Product 6", 216m },
                    { 5, "Description product 5", "Product 5", 681m },
                    { 4, "Description product 4", "Product 4", 116m },
                    { 3, "Description product 3", "Product 3", 720m },
                    { 2, "Description product 2", "Product 2", 276m },
                    { 23, "Description product 23", "Product 23", 671m },
                    { 49, "Description product 49", "Product 49", 724m },
                    { 24, "Description product 24", "Product 24", 447m },
                    { 26, "Description product 26", "Product 26", 284m },
                    { 47, "Description product 47", "Product 47", 298m },
                    { 46, "Description product 46", "Product 46", 290m },
                    { 45, "Description product 45", "Product 45", 511m },
                    { 44, "Description product 44", "Product 44", 562m },
                    { 43, "Description product 43", "Product 43", 473m },
                    { 42, "Description product 42", "Product 42", 666m },
                    { 41, "Description product 41", "Product 41", 507m },
                    { 40, "Description product 40", "Product 40", 127m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 39, "Description product 39", "Product 39", 729m },
                    { 38, "Description product 38", "Product 38", 990m },
                    { 37, "Description product 37", "Product 37", 692m },
                    { 36, "Description product 36", "Product 36", 597m },
                    { 35, "Description product 35", "Product 35", 712m },
                    { 34, "Description product 34", "Product 34", 121m },
                    { 33, "Description product 33", "Product 33", 879m },
                    { 32, "Description product 32", "Product 32", 136m },
                    { 31, "Description product 31", "Product 31", 750m },
                    { 30, "Description product 30", "Product 30", 515m },
                    { 29, "Description product 29", "Product 29", 211m },
                    { 28, "Description product 28", "Product 28", 581m },
                    { 27, "Description product 27", "Product 27", 676m },
                    { 25, "Description product 25", "Product 25", 768m },
                    { 99, "Description product 99", "Product 99", 120m }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 85 },
                    { 72, 72, 5 },
                    { 71, 71, 63 },
                    { 70, 70, 53 },
                    { 69, 69, 93 },
                    { 68, 68, 31 },
                    { 67, 67, 27 },
                    { 66, 66, 27 },
                    { 65, 65, 57 },
                    { 64, 64, 42 },
                    { 63, 63, 61 },
                    { 62, 62, 4 },
                    { 61, 61, 43 },
                    { 60, 60, 53 },
                    { 59, 59, 52 },
                    { 58, 58, 10 },
                    { 57, 57, 56 },
                    { 56, 56, 84 },
                    { 55, 55, 37 },
                    { 54, 54, 93 },
                    { 53, 53, 32 },
                    { 52, 52, 42 },
                    { 73, 73, 16 },
                    { 51, 51, 54 },
                    { 74, 74, 87 },
                    { 76, 76, 49 },
                    { 97, 97, 53 },
                    { 96, 96, 30 },
                    { 95, 95, 48 },
                    { 94, 94, 13 },
                    { 93, 93, 2 },
                    { 92, 92, 52 },
                    { 91, 91, 54 },
                    { 90, 90, 72 },
                    { 89, 89, 20 },
                    { 88, 88, 32 },
                    { 87, 87, 79 },
                    { 86, 86, 20 },
                    { 85, 85, 26 },
                    { 84, 84, 80 },
                    { 83, 83, 86 },
                    { 82, 82, 38 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 81, 81, 7 },
                    { 80, 80, 44 },
                    { 79, 79, 96 },
                    { 78, 78, 9 },
                    { 77, 77, 27 },
                    { 75, 75, 74 },
                    { 98, 98, 32 },
                    { 50, 50, 17 },
                    { 48, 48, 3 },
                    { 22, 22, 1 },
                    { 21, 21, 65 },
                    { 20, 20, 9 },
                    { 19, 19, 79 },
                    { 18, 18, 83 },
                    { 17, 17, 60 },
                    { 16, 16, 26 },
                    { 15, 15, 63 },
                    { 14, 14, 49 },
                    { 13, 13, 88 },
                    { 12, 12, 53 },
                    { 11, 11, 39 },
                    { 10, 10, 20 },
                    { 9, 9, 23 },
                    { 8, 8, 60 },
                    { 7, 7, 87 },
                    { 6, 6, 85 },
                    { 5, 5, 76 },
                    { 4, 4, 9 },
                    { 3, 3, 8 },
                    { 2, 2, 20 },
                    { 23, 23, 64 },
                    { 49, 49, 96 },
                    { 24, 24, 97 },
                    { 26, 26, 22 },
                    { 47, 47, 15 },
                    { 46, 46, 12 },
                    { 45, 45, 1 },
                    { 44, 44, 55 },
                    { 43, 43, 74 },
                    { 42, 42, 15 },
                    { 41, 41, 35 },
                    { 40, 40, 91 }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Stocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 39, 39, 66 },
                    { 38, 38, 54 },
                    { 37, 37, 62 },
                    { 36, 36, 10 },
                    { 35, 35, 56 },
                    { 34, 34, 57 },
                    { 33, 33, 25 },
                    { 32, 32, 12 },
                    { 31, 31, 62 },
                    { 30, 30, 80 },
                    { 29, 29, 98 },
                    { 28, 28, 82 },
                    { 27, 27, 42 },
                    { 25, 25, 57 },
                    { 99, 99, 97 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductId",
                schema: "Catalog",
                table: "Products",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductInStockId",
                schema: "Catalog",
                table: "Stocks",
                column: "ProductInStockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "Catalog");
        }
    }
}
