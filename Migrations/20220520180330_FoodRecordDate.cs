using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Migrations
{
    public partial class FoodRecordDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calories",
                table: "WeightLossGoals");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "FoodRecords",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1a38f500-2260-48d6-8bb4-2b981152e115");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3d8d5ca5-7a4e-4850-9494-0c1643f0aab2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "89119696-70ec-4c1b-89e4-19007e420d14", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "49c95636-7934-47d7-b2bd-ed1d7c17aef3", null });

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 5, 20, 21, 3, 30, 374, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 5, 20, 21, 3, 30, 374, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2022, 5, 19, 4, 21, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 5, 20, 21, 3, 30, 374, DateTimeKind.Local).AddTicks(7739));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "FoodRecords");

            migrationBuilder.AddColumn<int>(
                name: "Calories",
                table: "WeightLossGoals",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86a67702-8c7f-4880-b807-5de43c2fc135", "BOQD6BFFLWPX7GNRBP7ITK5DUCYFVMUF" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86a67702-8c7f-4880-b807-5de43c2fc135", "BOQD6BFFLWPX7GNRBP7ITK5DUCYFVMUF" });
        }
    }
}
