using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Migrations
{
    public partial class UsersMockData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "368339fe-0c13-4dd3-8019-8e211acebf9c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c826630a-2ac3-4195-a75f-f95ec1aea5e3");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RememberPassword", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "86a67702-8c7f-4880-b807-5de43c2fc135", "admin@admin.com", false, "Admy", "Nisterson", true, null, null, null, "AQAAAAEAACcQAAAAEMHhI7bKcvc+OSmYucr/dU7cRoCREp11U+oibZKHL4MGRUELRPwOVofNqZkOjty5Jw==", null, false, true, "BOQD6BFFLWPX7GNRBP7ITK5DUCYFVMUF", false, "admin@admin.com" },
                    { 2, 0, "499c1393-4898-482b-9747-c0c8b8f0abac", "user@example.com", false, "Usy", "Erson", true, null, null, null, "AQAAAAEAACcQAAAAEMHhI7bKcvc+OSmYucr/dU7cRoCREp11U+oibZKHL4MGRUELRPwOVofNqZkOjty5Jw==", null, false, true, "HKUSLCZJDZ6YJEVU32KEIPBXCDQNO3OK", false, "user@example.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 2, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "0efbfa12-0aba-4480-a2f1-1ca6588f9e2b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "07d6e17b-6bd4-40bb-bc9a-b63e549a5369");
        }
    }
}
