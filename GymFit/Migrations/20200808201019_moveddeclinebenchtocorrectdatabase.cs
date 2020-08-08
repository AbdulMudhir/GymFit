using Microsoft.EntityFrameworkCore.Migrations;

namespace GymFit.Migrations
{
    public partial class moveddeclinebenchtocorrectdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 6,
                column: "CategoryDetailId",
                value: 6);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ProductDetailId",
                keyValue: 6,
                column: "CategoryDetailId",
                value: 3);
        }
    }
}
