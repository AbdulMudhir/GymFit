using Microsoft.EntityFrameworkCore.Migrations;

namespace GymFit.Migrations
{
    public partial class categoriesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "/Images/Clothing.jpg", "Clothings" },
                    { 2, "/Images/Footwear.jpg", "FootWears" },
                    { 3, "/Images/equipments.jpg", "Equipments" },
                    { 4, "/Images/Suppliment.jpg", "Suppliments" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "SubCategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Men" },
                    { 2, "Women" },
                    { 3, "Weights/Dumbbells" },
                    { 4, "Fitness Equipment" }
                });

            migrationBuilder.InsertData(
                table: "CategoryDetails",
                columns: new[] { "CategoryDetailId", "CategoryId", "SubCategoryId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 3, 2, 1 },
                    { 2, 1, 2 },
                    { 4, 2, 2 },
                    { 5, 3, 3 },
                    { 6, 3, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CategoryDetails",
                keyColumn: "CategoryDetailId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryDetails",
                keyColumn: "CategoryDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryDetails",
                keyColumn: "CategoryDetailId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryDetails",
                keyColumn: "CategoryDetailId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CategoryDetails",
                keyColumn: "CategoryDetailId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CategoryDetails",
                keyColumn: "CategoryDetailId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "SubCategoryId",
                keyValue: 4);
        }
    }
}
