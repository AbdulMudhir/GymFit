using Microsoft.EntityFrameworkCore.Migrations;

namespace GymFit.Migrations
{
    public partial class populatedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Brand", "Description", "Ingredient", "IsFrontPageProduct", "Name", "ProductDetailId", "Safety", "Sale" },
                values: new object[,]
                {
                    { 1, null, null, null, true, "Dumb bells", 0, null, false },
                    { 2, "WHEY", " Optimum Nutrition’s Gold Standard Whey has been the world’s no 1 choice in whey protein powder for over 20 years. Having constantly refined their formula, the current incarnation of ON’s Gold Standard Whey is the most efficient and fast-absorbing yet, using whey protein isolates as the key ingredient, which help your muscles build and repair. Low quantities of sugar and fat keep things on the healthy side. Gold Standard Whey’s instantised ready-to-mix formula means you can enjoy it any time of day, whether shaken up in a bottle or as an addition to yourfavourite meals and drinks. Available in 1, 2, 5, 7 and 10-pound options. NOTE:Not every product has a hologram on the neck seal .", "Protein Blend (Whey Protein Isolates [contains Emulsifier: Soy Lecithin], Whey Protein Concentrate, Whey Peptides), Fat-Reduced Cocoa Powder, Flavorings, Sweeteners (Acesulfame Potassium, Sucralose), Enzyme Complex (Amylase, Protease, Cellulase, Beta-D-Galactosidase, Lipase)", false, "Whey Protien 100%", 0, "May contain- Gluten, Egg, Nuts and Peanuts.", false },
                    { 3, "WHEY", " Optimum Nutrition’s Gold Standard Whey has been the world’s no 1 choice in whey protein powder for over 20 years. Having constantly refined their formula, the current incarnation of ON’s Gold Standard Whey is the most efficient and fast-absorbing yet, using whey protein isolates as the key ingredient, which help your muscles build and repair. Low quantities of sugar and fat keep things on the healthy side. Gold Standard Whey’s instantised ready-to-mix formula means you can enjoy it any time of day, whether shaken up in a bottle or as an addition to yourfavourite meals and drinks. Available in 1, 2, 5, 7 and 10-pound options. NOTE:Not every product has a hologram on the neck seal .", "Protein Blend (Whey Protein Isolates [contains Emulsifier: Soy Lecithin], Whey Protein Concentrate, Whey Peptides), Fat-Reduced Cocoa Powder, Flavorings, Sweeteners (Acesulfame Potassium, Sucralose), Enzyme Complex (Amylase, Protease, Cellulase, Beta-D-Galactosidase, Lipase)", false, "Whey Protien 50%", 0, "May contain- Gluten, Egg, Nuts and Peanuts.", false },
                    { 4, null, null, null, true, "Decline BenchPress", 0, null, false }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "ProductDetailId", "CategoryDetailId", "Flavour", "PreviousPrice", "Price", "ProductId", "Size", "StockAmount", "Weights" },
                values: new object[,]
                {
                    { 1, 3, null, 240m, 120m, 1, 0, 2000, 0 },
                    { 6, 3, null, 240m, 120m, 2, 0, 2000, 0 },
                    { 2, 4, null, 84m, 40m, 3, 0, 2000, 0 },
                    { 3, 4, null, 324m, 20m, 3, 0, 2000, 0 },
                    { 4, 4, null, 84m, 40m, 4, 0, 2000, 0 },
                    { 5, 4, null, 324m, 20m, 4, 0, 2000, 0 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "Name", "ProductDetailId", "Url" },
                values: new object[,]
                {
                    { 1, null, 1, "/productimages/dumbbell1.png" },
                    { 2, null, 2, "/productimages/decline-benchpress.png" },
                    { 3, null, 3, "/productimages/whey.jpg" },
                    { 4, null, 4, "/productimages/bigwhey.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 1);

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
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);
        }
    }
}
