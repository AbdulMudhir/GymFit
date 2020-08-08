using Microsoft.EntityFrameworkCore.Migrations;

namespace GymFit.Migrations
{
    public partial class updatecorrectProductDetails2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 2,
                column: "ProductDetailId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 3,
                column: "ProductDetailId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 4,
                column: "ProductDetailId",
                value: 5);

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "Name", "ProductDetailId", "Url" },
                values: new object[,]
                {
                    { 5, null, 3, "/productimages/whey.jpg" },
                    { 6, null, 4, "/productimages/bigwhey.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 2,
                column: "ProductDetailId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 3,
                column: "ProductDetailId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 4,
                column: "ProductDetailId",
                value: 4);
        }
    }
}
