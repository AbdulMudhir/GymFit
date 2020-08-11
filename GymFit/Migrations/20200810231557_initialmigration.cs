using Microsoft.EntityFrameworkCore.Migrations;

namespace GymFit.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Safety = table.Column<string>(nullable: true),
                    Ingredient = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    ProductDetailId = table.Column<int>(nullable: false),
                    IsFrontPageProduct = table.Column<bool>(nullable: false),
                    Sale = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    SubCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SubCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryDetails",
                columns: table => new
                {
                    CategoryDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    SubCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryDetails", x => x.CategoryDetailId);
                    table.ForeignKey(
                        name: "FK_CategoryDetails_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryDetails_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "SubCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    ProductDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockAmount = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Size = table.Column<string>(nullable: true),
                    Flavour = table.Column<string>(nullable: true),
                    Weights = table.Column<int>(nullable: false),
                    CategoryDetailId = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    PreviousPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.ProductDetailId);
                    table.ForeignKey(
                        name: "FK_ProductDetails_CategoryDetails_CategoryDetailId",
                        column: x => x.CategoryDetailId,
                        principalTable: "CategoryDetails",
                        principalColumn: "CategoryDetailId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductDetailId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Images_ProductDetails_ProductDetailId",
                        column: x => x.ProductDetailId,
                        principalTable: "ProductDetails",
                        principalColumn: "ProductDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(nullable: false),
                    ProductDetailId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailsId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_ProductDetails_ProductDetailId",
                        column: x => x.ProductDetailId,
                        principalTable: "ProductDetails",
                        principalColumn: "ProductDetailId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "Products",
                columns: new[] { "ProductId", "Brand", "Description", "Ingredient", "IsFrontPageProduct", "Name", "ProductDetailId", "Safety", "Sale" },
                values: new object[,]
                {
                    { 1, null, @"Neoprene coated weights: These hand weights are neoprene coated dumbbells, which is non-slip. arteesol neoprene dumbbells use a hexagonal non-slip structure, which is relatively stable, ensuring your personal safety during use and protecting the floor from damage.
                Dumbbells can train the entire body: With only a pair of dumbbells you can perform multiple exercises for each and every muscle group.Various forms of dumbbell presses will work your chest, dumbbell rows for your back, raises and presses will target your shoulders while squats and lunges will obliterate your legs.
                Hand lifting weight dumbbells: Due to dumbbells’ size and the fact they can be held in each hand, dumbbells can be used to create a variety of different movement patterns to develop task -or movement - specific strength.
                Stylish appearance: arteesol dumbbells are printed weight number and color coding on each end cap for quick identification. Different weights with different colors, which could satisfied with your different favors.From 1kg to 10kg weights, it’s suitable for both men and women, as well as children and adults.
                Convenient & Room Saver: The dumbbells are small then they’re extremely convenient to carry.Great for home - trainees who have limited space and equipment.You could use dumbbells wherever you want such as at home or in gym or even during trip.", null, true, "Dumb bells", 0, "The equipment offers any user of the park an opportunity to increase their physical activity and is designed to give a mix of cardiovascular, strength and toning exercises. All equipment has clear guidelines for proper use and information on which part of the body it is benefitting.", false },
                    { 2, "WHEY", " Optimum Nutrition’s Gold Standard Whey has been the world’s no 1 choice in whey protein powder for over 20 years. Having constantly refined their formula, the current incarnation of ON’s Gold Standard Whey is the most efficient and fast-absorbing yet, using whey protein isolates as the key ingredient, which help your muscles build and repair. Low quantities of sugar and fat keep things on the healthy side. Gold Standard Whey’s instantised ready-to-mix formula means you can enjoy it any time of day, whether shaken up in a bottle or as an addition to yourfavourite meals and drinks. Available in 1, 2, 5, 7 and 10-pound options. NOTE:Not every product has a hologram on the neck seal .", "Protein Blend (Whey Protein Isolates [contains Emulsifier: Soy Lecithin], Whey Protein Concentrate, Whey Peptides), Fat-Reduced Cocoa Powder, Flavorings, Sweeteners (Acesulfame Potassium, Sucralose), Enzyme Complex (Amylase, Protease, Cellulase, Beta-D-Galactosidase, Lipase)", false, "Whey Protien 100%", 0, "May contain- Gluten, Egg, Nuts and Peanuts.", false },
                    { 3, "WHEY", " Optimum Nutrition’s Gold Standard Whey has been the world’s no 1 choice in whey protein powder for over 20 years. Having constantly refined their formula, the current incarnation of ON’s Gold Standard Whey is the most efficient and fast-absorbing yet, using whey protein isolates as the key ingredient, which help your muscles build and repair. Low quantities of sugar and fat keep things on the healthy side. Gold Standard Whey’s instantised ready-to-mix formula means you can enjoy it any time of day, whether shaken up in a bottle or as an addition to yourfavourite meals and drinks. Available in 1, 2, 5, 7 and 10-pound options. NOTE:Not every product has a hologram on the neck seal .", "Protein Blend (Whey Protein Isolates [contains Emulsifier: Soy Lecithin], Whey Protein Concentrate, Whey Peptides), Fat-Reduced Cocoa Powder, Flavorings, Sweeteners (Acesulfame Potassium, Sucralose), Enzyme Complex (Amylase, Protease, Cellulase, Beta-D-Galactosidase, Lipase)", false, "Whey Protien 50%", 0, "May contain- Gluten, Egg, Nuts and Peanuts.", false },
                    { 4, null, @"Neoprene coated weights: These hand weights are neoprene coated dumbbells, which is non-slip. arteesol neoprene dumbbells use a hexagonal non-slip structure, which is relatively stable, ensuring your personal safety during use and protecting the floor from damage.
                Dumbbells can train the entire body: With only a pair of dumbbells you can perform multiple exercises for each and every muscle group.Various forms of dumbbell presses will work your chest, dumbbell rows for your back, raises and presses will target your shoulders while squats and lunges will obliterate your legs.
                Hand lifting weight dumbbells: Due to dumbbells’ size and the fact they can be held in each hand, dumbbells can be used to create a variety of different movement patterns to develop task -or movement - specific strength.
                Stylish appearance: arteesol dumbbells are printed weight number and color coding on each end cap for quick identification. Different weights with different colors, which could satisfied with your different favors.From 1kg to 10kg weights, it’s suitable for both men and women, as well as children and adults.
                Convenient & Room Saver: The dumbbells are small then they’re extremely convenient to carry.Great for home - trainees who have limited space and equipment.You could use dumbbells wherever you want such as at home or in gym or even during trip.", null, true, "Decline BenchPress", 0, "The equipment offers any user of the park an opportunity to increase their physical activity and is designed to give a mix of cardiovascular, strength and toning exercises. All equipment has clear guidelines for proper use and information on which part of the body it is benefitting.", false }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "SubCategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Men" },
                    { 2, "Women" },
                    { 3, "Weights/Dumbbells" },
                    { 4, "Fitness Equipment" },
                    { 5, null }
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
                    { 6, 3, 4 },
                    { 7, 4, 5 }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "ProductDetailId", "CategoryDetailId", "Flavour", "PreviousPrice", "Price", "ProductId", "Size", "StockAmount", "Weights" },
                values: new object[,]
                {
                    { 1, 5, null, 240m, 120m, 1, null, 2000, 0 },
                    { 6, 6, null, 240m, 120m, 4, null, 2000, 0 },
                    { 2, 7, "Extreme Chocolate", 84m, 40m, 3, "2.5kg", 2000, 0 },
                    { 3, 7, "Extreme Chocolate", 324m, 20m, 3, "1.5kg", 2000, 0 },
                    { 4, 7, "Vanilla Chocolate", 84m, 40m, 2, "2.5kg", 2000, 0 },
                    { 5, 7, "Vanilla Chocolate", 324m, 20m, 2, "1.5kg", 2000, 0 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "Name", "ProductDetailId", "Url" },
                values: new object[,]
                {
                    { 1, null, 1, "/productimages/dumbbell1.png" },
                    { 2, null, 6, "/productimages/decline-benchpress.png" },
                    { 3, null, 2, "/productimages/whey.jpg" },
                    { 4, null, 3, "/productimages/bigwhey.png" },
                    { 6, null, 4, "/productimages/bigwhey.png" },
                    { 5, null, 5, "/productimages/whey.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryDetails_CategoryId",
                table: "CategoryDetails",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryDetails_SubCategoryId",
                table: "CategoryDetails",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductDetailId",
                table: "Images",
                column: "ProductDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductDetailId",
                table: "OrderDetails",
                column: "ProductDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_CategoryDetailId",
                table: "ProductDetails",
                column: "CategoryDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductId",
                table: "ProductDetails",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "CategoryDetails");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "SubCategories");
        }
    }
}
