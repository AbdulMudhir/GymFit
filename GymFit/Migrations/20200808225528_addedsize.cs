using Microsoft.EntityFrameworkCore.Migrations;

namespace GymFit.Migrations
{
    public partial class addedsize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Size",
                table: "ProductDetails",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 1,
                column: "Size",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 2,
                column: "Size",
                value: "2.5kg");

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 3,
                column: "Size",
                value: "1.5kg");

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 4,
                column: "Size",
                value: "2.5kg");

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 5,
                column: "Size",
                value: "1.5kg");

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 6,
                column: "Size",
                value: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Size",
                table: "ProductDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 1,
                column: "Size",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 2,
                column: "Size",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 3,
                column: "Size",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 4,
                column: "Size",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 5,
                column: "Size",
                value: 0);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 6,
                column: "Size",
                value: 0);
        }
    }
}
