using Microsoft.EntityFrameworkCore.Migrations;

namespace FastFoodRestaurant.Migrations
{
    public partial class UpdatePrimaryKeyForBothColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Products_PointsId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_PointsId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "PointsId",
                table: "Customers");

            migrationBuilder.AddColumn<byte>(
                name: "Points",
                table: "Customers",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Points",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "PointsId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PointsId",
                table: "Customers",
                column: "PointsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Products_PointsId",
                table: "Customers",
                column: "PointsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
