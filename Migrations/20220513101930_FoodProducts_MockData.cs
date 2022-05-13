using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Migrations
{
    public partial class FoodProducts_MockData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FoodProducts",
                columns: new[] { "Id", "Calories100g", "Carbohydrates100g", "Fats100g", "ImageUrl", "Name", "Proteins100g" },
                values: new object[,]
                {
                    { 1, 364.9f, 65.2f, 4.9f, "", "Steak", 15f },
                    { 2, 209.3f, 37.2f, 1.16f, "", "Whole grain bread", 6.98f },
                    { 3, 230.1f, 30.2f, 8.1f, "", "Pineapple Pizza", 9.4f },
                    { 4, 50f, 4.9f, 2f, "", "Milk", 3.3f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodProducts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FoodProducts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FoodProducts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FoodProducts",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
