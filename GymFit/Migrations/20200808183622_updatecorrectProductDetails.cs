using Microsoft.EntityFrameworkCore.Migrations;

namespace GymFit.Migrations
{
    public partial class updatecorrectProductDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 4,
                column: "ProductId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 5,
                column: "ProductId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 6,
                column: "ProductId",
                value: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 4,
                column: "ProductId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 5,
                column: "ProductId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 6,
                column: "ProductId",
                value: 2);
        }
    }
}
