using Microsoft.EntityFrameworkCore.Migrations;

namespace GymFit.Migrations
{
    public partial class fixedsupplments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 1,
                column: "CategoryDetailId",
                value: 5);

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "SubCategoryId", "Name" },
                values: new object[] { 5, null });

            migrationBuilder.InsertData(
                table: "CategoryDetails",
                columns: new[] { "CategoryDetailId", "CategoryId", "SubCategoryId" },
                values: new object[] { 7, 4, 5 });

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 2,
                column: "CategoryDetailId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 3,
                column: "CategoryDetailId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 4,
                column: "CategoryDetailId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 5,
                column: "CategoryDetailId",
                value: 7);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CategoryDetails",
                keyColumn: "CategoryDetailId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 1,
                column: "CategoryDetailId",
                value: 3);

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "ProductDetailId", "CategoryDetailId", "Flavour", "PreviousPrice", "Price", "ProductId", "Size", "StockAmount", "Weights" },
                values: new object[,]
                {
                    { 5, 4, null, 324m, 20m, 2, 0, 2000, 0 },
                    { 4, 4, null, 84m, 40m, 2, 0, 2000, 0 },
                    { 3, 4, null, 324m, 20m, 3, 0, 2000, 0 },
                    { 2, 4, null, 84m, 40m, 3, 0, 2000, 0 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "Name", "ProductDetailId", "Url" },
                values: new object[,]
                {
                    { 4, null, 5, "/productimages/bigwhey.png" },
                    { 6, null, 4, "/productimages/bigwhey.png" },
                    { 5, null, 3, "/productimages/whey.jpg" },
                    { 3, null, 2, "/productimages/whey.jpg" }
                });
        }
    }
}
