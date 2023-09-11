using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LasticShop.Migrations
{
    /// <inheritdoc />
    public partial class AddProductImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductsImages_Products_ProductId",
                table: "ProductsImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductsImages",
                table: "ProductsImages");

            migrationBuilder.RenameTable(
                name: "ProductsImages",
                newName: "PrImages");

            migrationBuilder.RenameIndex(
                name: "IX_ProductsImages_ProductId",
                table: "PrImages",
                newName: "IX_PrImages_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrImages",
                table: "PrImages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PrImages_Products_ProductId",
                table: "PrImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrImages_Products_ProductId",
                table: "PrImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrImages",
                table: "PrImages");

            migrationBuilder.RenameTable(
                name: "PrImages",
                newName: "ProductsImages");

            migrationBuilder.RenameIndex(
                name: "IX_PrImages_ProductId",
                table: "ProductsImages",
                newName: "IX_ProductsImages_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductsImages",
                table: "ProductsImages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductsImages_Products_ProductId",
                table: "ProductsImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
