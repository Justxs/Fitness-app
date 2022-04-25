using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessApp.Migrations
{
    public partial class DatabaseFirstToCodeFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ID_FoodCategory_FoodCategory = table.Column<int>(type: "int", nullable: true)
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
                name: "FoodProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calories100g = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calories1min = table.Column<int>(type: "int", nullable: false)
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
                    ID_UserData = table.Column<int>(type: "int", nullable: false),
                    ID_FoodAllergy_CanHAve = table.Column<int>(type: "int", nullable: false)
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
                    ID_UserData = table.Column<int>(type: "int", nullable: false),
                    ID_FoodCategory_NotPrefer = table.Column<int>(type: "int", nullable: false)
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
                    ID_UserData = table.Column<int>(type: "int", nullable: false),
                    ID_FoodCategory_Prefer = table.Column<int>(type: "int", nullable: false)
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
                name: "AppliesTos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_FoodAllergy = table.Column<int>(type: "int", nullable: false),
                    ID_FoodProduct_AppliesTo = table.Column<int>(type: "int", nullable: false)
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
                    ID_FoodCategory = table.Column<int>(type: "int", nullable: false),
                    ID_FoodProduct_ContainsProd = table.Column<int>(type: "int", nullable: false)
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
                name: "CaloriesRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChangeInCalories = table.Column<double>(type: "float", nullable: true),
                    ID_UserData_CaloriesRecord = table.Column<int>(type: "int", nullable: false)
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
                name: "PhysicalStateRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    ID_UserData_PhysicalStateRecord = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysicalStateRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhysicalStateRecords_Userdata_ID_UserData_PhysicalStateRecord",
                        column: x => x.ID_UserData_PhysicalStateRecord,
                        principalTable: "Userdata",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeightLossGoals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartWeight = table.Column<double>(type: "float", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndWeight = table.Column<double>(type: "float", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    ID_UserData_WeightLossGoal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightLossGoals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeightLossGoals_Userdata_ID_UserData_WeightLossGoal",
                        column: x => x.ID_UserData_WeightLossGoal,
                        principalTable: "Userdata",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhysicalActivityRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Minutes = table.Column<double>(type: "float", nullable: false),
                    ID_CaloriesRecord_PhysicalActivityRecord = table.Column<int>(type: "int", nullable: false),
                    ID_PhysicalActivity_PhysicalActivityRecord = table.Column<int>(type: "int", nullable: false)
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
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Steps = table.Column<int>(type: "int", nullable: false),
                    ID_CaloriesRecord_StepsRecord = table.Column<int>(type: "int", nullable: false)
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
                name: "EatingActivityRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grams = table.Column<int>(type: "int", nullable: false),
                    ID_CaloriesRecord_EatingActivityRecord = table.Column<int>(type: "int", nullable: true),
                    ID_FoodProduct_EatingActivityRecord = table.Column<int>(type: "int", nullable: true),
                    DietId = table.Column<int>(type: "int", nullable: true)
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
                name: "IX_PhysicalStateRecords_ID_UserData_PhysicalStateRecord",
                table: "PhysicalStateRecords",
                column: "ID_UserData_PhysicalStateRecord");

            migrationBuilder.CreateIndex(
                name: "IX_Prefers_ID_FoodCategory_Prefer",
                table: "Prefers",
                column: "ID_FoodCategory_Prefer");

            migrationBuilder.CreateIndex(
                name: "IX_StepsRecords_ID_CaloriesRecord_StepsRecord",
                table: "StepsRecords",
                column: "ID_CaloriesRecord_StepsRecord",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WeightLossGoals_ID_UserData_WeightLossGoal",
                table: "WeightLossGoals",
                column: "ID_UserData_WeightLossGoal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "PhysicalStateRecords");

            migrationBuilder.DropTable(
                name: "Prefers");

            migrationBuilder.DropTable(
                name: "StepsRecords");

            migrationBuilder.DropTable(
                name: "FoodAllergies");

            migrationBuilder.DropTable(
                name: "Diets");

            migrationBuilder.DropTable(
                name: "FoodProducts");

            migrationBuilder.DropTable(
                name: "PhysicalActivities");

            migrationBuilder.DropTable(
                name: "FoodCategories");

            migrationBuilder.DropTable(
                name: "CaloriesRecords");

            migrationBuilder.DropTable(
                name: "WeightLossGoals");

            migrationBuilder.DropTable(
                name: "Userdata");
        }
    }
}
