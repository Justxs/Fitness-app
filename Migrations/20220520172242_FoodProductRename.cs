using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Migrations
{
    public partial class FoodProductRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodProducts");

            migrationBuilder.CreateTable(
                name: "FoodRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Proteins100g = table.Column<float>(type: "real", nullable: false),
                    Carbohydrates100g = table.Column<float>(type: "real", nullable: false),
                    Fats100g = table.Column<float>(type: "real", nullable: false),
                    Calories100g = table.Column<float>(type: "real", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodRecords_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "40575b46-861d-4a84-b793-b4f222d5cc82", "Admin" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "fd35a1c6-e55a-4918-9e41-7902685f161c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EmailConfirmed", "LockoutEnabled" },
                values: new object[] { true, false });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "LockoutEnabled", "SecurityStamp" },
                values: new object[] { "86a67702-8c7f-4880-b807-5de43c2fc135", true, false, "BOQD6BFFLWPX7GNRBP7ITK5DUCYFVMUF" });

            migrationBuilder.InsertData(
                table: "FoodRecords",
                columns: new[] { "Id", "Calories100g", "Carbohydrates100g", "Fats100g", "ImageUrl", "Name", "Proteins100g", "UserId" },
                values: new object[,]
                {
                    { 1, 364.9f, 65.2f, 4.9f, "", "Steak", 15f, 2 },
                    { 2, 209.3f, 37.2f, 1.16f, "", "Whole grain bread", 6.98f, 2 },
                    { 3, 230.1f, 30.2f, 8.1f, "", "Pineapple Pizza", 9.4f, 2 },
                    { 4, 50f, 4.9f, 2f, "", "Milk", 3.3f, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodRecords_UserId",
                table: "FoodRecords",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodRecords");

            migrationBuilder.CreateTable(
                name: "FoodProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calories100g = table.Column<float>(type: "real", nullable: false),
                    Carbohydrates100g = table.Column<float>(type: "real", nullable: false),
                    Fats100g = table.Column<float>(type: "real", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Proteins100g = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodProducts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "bed7f064-6c0c-4893-8a36-c203a4862cb9", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a005db81-8177-454b-be78-7e6216f1660c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EmailConfirmed", "LockoutEnabled" },
                values: new object[] { false, true });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "LockoutEnabled", "SecurityStamp" },
                values: new object[] { "499c1393-4898-482b-9747-c0c8b8f0abac", false, true, "HKUSLCZJDZ6YJEVU32KEIPBXCDQNO3OK" });

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
    }
}
