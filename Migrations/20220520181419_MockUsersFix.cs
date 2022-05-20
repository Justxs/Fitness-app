using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Migrations
{
    public partial class MockUsersFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2b3d9a3f-12d0-434d-bd90-6428420d3f3d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "ef6d7a4c-562e-4491-b2af-f536967f0c90");

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

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2022, 5, 20, 21, 14, 18, 802, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2022, 5, 20, 21, 14, 18, 802, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "FoodRecords",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 5, 20, 21, 14, 18, 802, DateTimeKind.Local).AddTicks(8054));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 4,
                column: "Date",
                value: new DateTime(2022, 5, 20, 21, 3, 30, 374, DateTimeKind.Local).AddTicks(7739));
        }
    }
}
