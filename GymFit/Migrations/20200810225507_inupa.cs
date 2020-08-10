using Microsoft.EntityFrameworkCore.Migrations;

namespace GymFit.Migrations
{
    public partial class inupa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "Safety" },
                values: new object[] { @"Neoprene coated weights: These hand weights are neoprene coated dumbbells, which is non-slip. arteesol neoprene dumbbells use a hexagonal non-slip structure, which is relatively stable, ensuring your personal safety during use and protecting the floor from damage.
Dumbbells can train the entire body: With only a pair of dumbbells you can perform multiple exercises for each and every muscle group.Various forms of dumbbell presses will work your chest, dumbbell rows for your back, raises and presses will target your shoulders while squats and lunges will obliterate your legs.
Hand lifting weight dumbbells: Due to dumbbells’ size and the fact they can be held in each hand, dumbbells can be used to create a variety of different movement patterns to develop task -or movement - specific strength.
Stylish appearance: arteesol dumbbells are printed weight number and color coding on each end cap for quick identification. Different weights with different colors, which could satisfied with your different favors.From 1kg to 10kg weights, it’s suitable for both men and women, as well as children and adults.
Convenient & Room Saver: The dumbbells are small then they’re extremely convenient to carry.Great for home - trainees who have limited space and equipment.You could use dumbbells wherever you want such as at home or in gym or even during trip.", "The equipment offers any user of the park an opportunity to increase their physical activity and is designed to give a mix of cardiovascular, strength and toning exercises. All equipment has clear guidelines for proper use and information on which part of the body it is benefitting." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Description", "Safety" },
                values: new object[] { @"Neoprene coated weights: These hand weights are neoprene coated dumbbells, which is non-slip. arteesol neoprene dumbbells use a hexagonal non-slip structure, which is relatively stable, ensuring your personal safety during use and protecting the floor from damage.
Dumbbells can train the entire body: With only a pair of dumbbells you can perform multiple exercises for each and every muscle group.Various forms of dumbbell presses will work your chest, dumbbell rows for your back, raises and presses will target your shoulders while squats and lunges will obliterate your legs.
Hand lifting weight dumbbells: Due to dumbbells’ size and the fact they can be held in each hand, dumbbells can be used to create a variety of different movement patterns to develop task -or movement - specific strength.
Stylish appearance: arteesol dumbbells are printed weight number and color coding on each end cap for quick identification. Different weights with different colors, which could satisfied with your different favors.From 1kg to 10kg weights, it’s suitable for both men and women, as well as children and adults.
Convenient & Room Saver: The dumbbells are small then they’re extremely convenient to carry.Great for home - trainees who have limited space and equipment.You could use dumbbells wherever you want such as at home or in gym or even during trip.", "The equipment offers any user of the park an opportunity to increase their physical activity and is designed to give a mix of cardiovascular, strength and toning exercises. All equipment has clear guidelines for proper use and information on which part of the body it is benefitting." });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Description", "Safety" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Description", "Safety" },
                values: new object[] { null, null });
        }
    }
}
