using Microsoft.EntityFrameworkCore.Migrations;

namespace GymFit.Migrations
{
    public partial class movedSomeImAGESfORTESITNG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 4,
                column: "ProductDetailId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 5,
                column: "ProductDetailId",
                value: 5);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 4,
                column: "ProductDetailId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 5,
                column: "ProductDetailId",
                value: 3);
        }
    }
}
