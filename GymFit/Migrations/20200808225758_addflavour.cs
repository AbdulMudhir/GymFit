using Microsoft.EntityFrameworkCore.Migrations;

namespace GymFit.Migrations
{
    public partial class addflavour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 2,
                column: "Flavour",
                value: "Extreme Chocolate");

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 3,
                column: "Flavour",
                value: "Extreme Chocolate");

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 4,
                column: "Flavour",
                value: "Vanilla Chocolate");

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 5,
                column: "Flavour",
                value: "Vanilla Chocolate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 2,
                column: "Flavour",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 3,
                column: "Flavour",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 4,
                column: "Flavour",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 5,
                column: "Flavour",
                value: null);
        }
    }
}
