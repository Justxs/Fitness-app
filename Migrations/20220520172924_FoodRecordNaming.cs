using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Migrations
{
    public partial class FoodRecordNaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Proteins100g",
                table: "FoodRecords",
                newName: "Proteins");

            migrationBuilder.RenameColumn(
                name: "Fats100g",
                table: "FoodRecords",
                newName: "Fats");

            migrationBuilder.RenameColumn(
                name: "Carbohydrates100g",
                table: "FoodRecords",
                newName: "Carbohydrates");

            migrationBuilder.RenameColumn(
                name: "Calories100g",
                table: "FoodRecords",
                newName: "Calories");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "659eb4fa-ba38-47c6-a4fd-95a791e326cb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "42b8cb96-f1ff-4c51-ba54-d80d036bb2e1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Proteins",
                table: "FoodRecords",
                newName: "Proteins100g");

            migrationBuilder.RenameColumn(
                name: "Fats",
                table: "FoodRecords",
                newName: "Fats100g");

            migrationBuilder.RenameColumn(
                name: "Carbohydrates",
                table: "FoodRecords",
                newName: "Carbohydrates100g");

            migrationBuilder.RenameColumn(
                name: "Calories",
                table: "FoodRecords",
                newName: "Calories100g");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "40575b46-861d-4a84-b793-b4f222d5cc82");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "fd35a1c6-e55a-4918-9e41-7902685f161c");
        }
    }
}
