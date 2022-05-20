using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Migrations
{
    public partial class DatabaseCleanup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhysicalStateRecords_Userdata_ID_UserData_PhysicalStateRecord",
                table: "PhysicalStateRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_WeightLossGoals_Userdata_ID_UserData_WeightLossGoal",
                table: "WeightLossGoals");

            migrationBuilder.DropTable(
                name: "AppliesTos");

            migrationBuilder.DropTable(
                name: "CanHaves");

            migrationBuilder.DropTable(
                name: "ContainsProds");

            migrationBuilder.DropTable(
                name: "EatingActivityRecords");

            migrationBuilder.DropTable(
                name: "NotPrefers");

            migrationBuilder.DropTable(
                name: "PhysicalActivityRecords");

            migrationBuilder.DropTable(
                name: "Prefers");

            migrationBuilder.DropTable(
                name: "StepsRecords");

            migrationBuilder.DropTable(
                name: "FoodAllergies");

            migrationBuilder.DropTable(
                name: "Diets");

            migrationBuilder.DropTable(
                name: "PhysicalActivities");

            migrationBuilder.DropTable(
                name: "FoodCategories");

            migrationBuilder.DropTable(
                name: "CaloriesRecords");

            migrationBuilder.DropTable(
                name: "Userdata");

            migrationBuilder.RenameColumn(
                name: "ID_UserData_WeightLossGoal",
                table: "WeightLossGoals",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_WeightLossGoals_ID_UserData_WeightLossGoal",
                table: "WeightLossGoals",
                newName: "IX_WeightLossGoals_UserId");

            migrationBuilder.RenameColumn(
                name: "ID_UserData_PhysicalStateRecord",
                table: "PhysicalStateRecords",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_PhysicalStateRecords_ID_UserData_PhysicalStateRecord",
                table: "PhysicalStateRecords",
                newName: "IX_PhysicalStateRecords_UserId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "bed7f064-6c0c-4893-8a36-c203a4862cb9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a005db81-8177-454b-be78-7e6216f1660c");

            migrationBuilder.AddForeignKey(
                name: "FK_PhysicalStateRecords_AspNetUsers_UserId",
                table: "PhysicalStateRecords",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeightLossGoals_AspNetUsers_UserId",
                table: "WeightLossGoals",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhysicalStateRecords_AspNetUsers_UserId",
                table: "PhysicalStateRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_WeightLossGoals_AspNetUsers_UserId",
                table: "WeightLossGoals");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "WeightLossGoals",
                newName: "ID_UserData_WeightLossGoal");

            migrationBuilder.RenameIndex(
                name: "IX_WeightLossGoals_UserId",
                table: "WeightLossGoals",
                newName: "IX_WeightLossGoals_ID_UserData_WeightLossGoal");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "PhysicalStateRecords",
                newName: "ID_UserData_PhysicalStateRecord");

            migrationBuilder.RenameIndex(
                name: "IX_PhysicalStateRecords_UserId",
                table: "PhysicalStateRecords",
                newName: "IX_PhysicalStateRecords_ID_UserData_PhysicalStateRecord");

            migrationBuilder.CreateTable(
                name: "AppliesTos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_FoodProduct_AppliesTo = table.Column<int>(type: "int", nullable: false),
                    ID_FoodAllergy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppliesTos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppliesTos_FoodProducts_ID_FoodProduct_AppliesTo",
                        column: x => x.ID_FoodProduct_AppliesTo,
                        principalTable: "FoodProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContainsProds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_FoodProduct_ContainsProd = table.Column<int>(type: "int", nullable: false),
                    ID_FoodCategory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContainsProds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContainsProds_FoodProducts_ID_FoodProduct_ContainsProd",
                        column: x => x.ID_FoodProduct_ContainsProd,
                        principalTable: "FoodProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_WeightLossGoal_Diet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diets_WeightLossGoals_ID_WeightLossGoal_Diet",
                        column: x => x.ID_WeightLossGoal_Diet,
                        principalTable: "WeightLossGoals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodAllergies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodAllergies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_FoodCategory_FoodCategory = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodCategories_FoodCategories_ID_FoodCategory_FoodCategory",
                        column: x => x.ID_FoodCategory_FoodCategory,
                        principalTable: "FoodCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PhysicalActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calories1min = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalActivities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Userdata",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userdata", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CanHaves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_FoodAllergy_CanHAve = table.Column<int>(type: "int", nullable: false),
                    ID_UserData = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanHaves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CanHaves_FoodAllergies_ID_FoodAllergy_CanHAve",
                        column: x => x.ID_FoodAllergy_CanHAve,
                        principalTable: "FoodAllergies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NotPrefers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_FoodCategory_NotPrefer = table.Column<int>(type: "int", nullable: false),
                    ID_UserData = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotPrefers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotPrefers_FoodCategories_ID_FoodCategory_NotPrefer",
                        column: x => x.ID_FoodCategory_NotPrefer,
                        principalTable: "FoodCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prefers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_FoodCategory_Prefer = table.Column<int>(type: "int", nullable: false),
                    ID_UserData = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prefers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prefers_FoodCategories_ID_FoodCategory_Prefer",
                        column: x => x.ID_FoodCategory_Prefer,
                        principalTable: "FoodCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CaloriesRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_UserData_CaloriesRecord = table.Column<int>(type: "int", nullable: false),
                    ChangeInCalories = table.Column<double>(type: "float", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaloriesRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaloriesRecords_Userdata_ID_UserData_CaloriesRecord",
                        column: x => x.ID_UserData_CaloriesRecord,
                        principalTable: "Userdata",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EatingActivityRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CaloriesRecord_EatingActivityRecord = table.Column<int>(type: "int", nullable: true),
                    ID_FoodProduct_EatingActivityRecord = table.Column<int>(type: "int", nullable: true),
                    DietId = table.Column<int>(type: "int", nullable: true),
                    Grams = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EatingActivityRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EatingActivityRecords_CaloriesRecords_ID_CaloriesRecord_EatingActivityRecord",
                        column: x => x.ID_CaloriesRecord_EatingActivityRecord,
                        principalTable: "CaloriesRecords",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EatingActivityRecords_Diets_DietId",
                        column: x => x.DietId,
                        principalTable: "Diets",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EatingActivityRecords_FoodProducts_ID_FoodProduct_EatingActivityRecord",
                        column: x => x.ID_FoodProduct_EatingActivityRecord,
                        principalTable: "FoodProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PhysicalActivityRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CaloriesRecord_PhysicalActivityRecord = table.Column<int>(type: "int", nullable: false),
                    ID_PhysicalActivity_PhysicalActivityRecord = table.Column<int>(type: "int", nullable: false),
                    Minutes = table.Column<double>(type: "float", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalActivityRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhysicalActivityRecords_CaloriesRecords_ID_CaloriesRecord_PhysicalActivityRecord",
                        column: x => x.ID_CaloriesRecord_PhysicalActivityRecord,
                        principalTable: "CaloriesRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhysicalActivityRecords_PhysicalActivities_ID_PhysicalActivity_PhysicalActivityRecord",
                        column: x => x.ID_PhysicalActivity_PhysicalActivityRecord,
                        principalTable: "PhysicalActivities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StepsRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_CaloriesRecord_StepsRecord = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Steps = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StepsRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StepsRecords_CaloriesRecords_ID_CaloriesRecord_StepsRecord",
                        column: x => x.ID_CaloriesRecord_StepsRecord,
                        principalTable: "CaloriesRecords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "9fc9e7fa-0ff9-4b31-9b2e-fa9cd5aca66b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "fae3bf64-bcd6-4d7e-8409-788426db26ef");

            migrationBuilder.CreateIndex(
                name: "IX_AppliesTos_ID_FoodProduct_AppliesTo",
                table: "AppliesTos",
                column: "ID_FoodProduct_AppliesTo");

            migrationBuilder.CreateIndex(
                name: "IX_CaloriesRecords_ID_UserData_CaloriesRecord",
                table: "CaloriesRecords",
                column: "ID_UserData_CaloriesRecord");

            migrationBuilder.CreateIndex(
                name: "IX_CanHaves_ID_FoodAllergy_CanHAve",
                table: "CanHaves",
                column: "ID_FoodAllergy_CanHAve");

            migrationBuilder.CreateIndex(
                name: "IX_ContainsProds_ID_FoodProduct_ContainsProd",
                table: "ContainsProds",
                column: "ID_FoodProduct_ContainsProd");

            migrationBuilder.CreateIndex(
                name: "IX_Diets_ID_WeightLossGoal_Diet",
                table: "Diets",
                column: "ID_WeightLossGoal_Diet");

            migrationBuilder.CreateIndex(
                name: "IX_EatingActivityRecords_DietId",
                table: "EatingActivityRecords",
                column: "DietId");

            migrationBuilder.CreateIndex(
                name: "IX_EatingActivityRecords_ID_CaloriesRecord_EatingActivityRecord",
                table: "EatingActivityRecords",
                column: "ID_CaloriesRecord_EatingActivityRecord",
                unique: true,
                filter: "[ID_CaloriesRecord_EatingActivityRecord] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_EatingActivityRecords_ID_FoodProduct_EatingActivityRecord",
                table: "EatingActivityRecords",
                column: "ID_FoodProduct_EatingActivityRecord");

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategories_ID_FoodCategory_FoodCategory",
                table: "FoodCategories",
                column: "ID_FoodCategory_FoodCategory");

            migrationBuilder.CreateIndex(
                name: "IX_NotPrefers_ID_FoodCategory_NotPrefer",
                table: "NotPrefers",
                column: "ID_FoodCategory_NotPrefer");

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalActivityRecords_ID_CaloriesRecord_PhysicalActivityRecord",
                table: "PhysicalActivityRecords",
                column: "ID_CaloriesRecord_PhysicalActivityRecord",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhysicalActivityRecords_ID_PhysicalActivity_PhysicalActivityRecord",
                table: "PhysicalActivityRecords",
                column: "ID_PhysicalActivity_PhysicalActivityRecord");

            migrationBuilder.CreateIndex(
                name: "IX_Prefers_ID_FoodCategory_Prefer",
                table: "Prefers",
                column: "ID_FoodCategory_Prefer");

            migrationBuilder.CreateIndex(
                name: "IX_StepsRecords_ID_CaloriesRecord_StepsRecord",
                table: "StepsRecords",
                column: "ID_CaloriesRecord_StepsRecord",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PhysicalStateRecords_Userdata_ID_UserData_PhysicalStateRecord",
                table: "PhysicalStateRecords",
                column: "ID_UserData_PhysicalStateRecord",
                principalTable: "Userdata",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeightLossGoals_Userdata_ID_UserData_WeightLossGoal",
                table: "WeightLossGoals",
                column: "ID_UserData_WeightLossGoal",
                principalTable: "Userdata",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
