﻿// <auto-generated />
using System;
using FitnessApp.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitnessApp.Migrations
{
    [DbContext(typeof(FitnessAppDbContext))]
    [Migration("20220513112912_AuthenticationStoreFix")]
    partial class AuthenticationStoreFix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FitnessApp.Database.Models.AppliesTo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ID_FoodAllergy")
                        .HasColumnType("int");

                    b.Property<int>("ID_FoodProduct_AppliesTo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ID_FoodProduct_AppliesTo");

                    b.ToTable("AppliesTos");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.CaloriesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double?>("ChangeInCalories")
                        .HasColumnType("float");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ID_UserData_CaloriesRecord")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ID_UserData_CaloriesRecord");

                    b.ToTable("CaloriesRecords");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.CanHave", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ID_FoodAllergy_CanHAve")
                        .HasColumnType("int");

                    b.Property<int>("ID_UserData")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ID_FoodAllergy_CanHAve");

                    b.ToTable("CanHaves");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.ContainsProd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ID_FoodCategory")
                        .HasColumnType("int");

                    b.Property<int>("ID_FoodProduct_ContainsProd")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ID_FoodProduct_ContainsProd");

                    b.ToTable("ContainsProds");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.Diet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ID_WeightLossGoal_Diet")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ID_WeightLossGoal_Diet");

                    b.ToTable("Diets");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.EatingActivityRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("DietId")
                        .HasColumnType("int");

                    b.Property<int>("Grams")
                        .HasColumnType("int");

                    b.Property<int?>("ID_CaloriesRecord_EatingActivityRecord")
                        .HasColumnType("int");

                    b.Property<int?>("ID_FoodProduct_EatingActivityRecord")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DietId");

                    b.HasIndex("ID_CaloriesRecord_EatingActivityRecord")
                        .IsUnique()
                        .HasFilter("[ID_CaloriesRecord_EatingActivityRecord] IS NOT NULL");

                    b.HasIndex("ID_FoodProduct_EatingActivityRecord");

                    b.ToTable("EatingActivityRecords");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.FoodAllergy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FoodAllergies");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.FoodCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ID_FoodCategory_FoodCategory")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ID_FoodCategory_FoodCategory");

                    b.ToTable("FoodCategories");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.FoodProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<float>("Calories100g")
                        .HasColumnType("real");

                    b.Property<float>("Carbohydrates100g")
                        .HasColumnType("real");

                    b.Property<float>("Fats100g")
                        .HasColumnType("real");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Proteins100g")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("FoodProducts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calories100g = 364.9f,
                            Carbohydrates100g = 65.2f,
                            Fats100g = 4.9f,
                            ImageUrl = "",
                            Name = "Steak",
                            Proteins100g = 15f
                        },
                        new
                        {
                            Id = 2,
                            Calories100g = 209.3f,
                            Carbohydrates100g = 37.2f,
                            Fats100g = 1.16f,
                            ImageUrl = "",
                            Name = "Whole grain bread",
                            Proteins100g = 6.98f
                        },
                        new
                        {
                            Id = 3,
                            Calories100g = 230.1f,
                            Carbohydrates100g = 30.2f,
                            Fats100g = 8.1f,
                            ImageUrl = "",
                            Name = "Pineapple Pizza",
                            Proteins100g = 9.4f
                        },
                        new
                        {
                            Id = 4,
                            Calories100g = 50f,
                            Carbohydrates100g = 4.9f,
                            Fats100g = 2f,
                            ImageUrl = "",
                            Name = "Milk",
                            Proteins100g = 3.3f
                        });
                });

            modelBuilder.Entity("FitnessApp.Database.Models.NotPrefer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ID_FoodCategory_NotPrefer")
                        .HasColumnType("int");

                    b.Property<int>("ID_UserData")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ID_FoodCategory_NotPrefer");

                    b.ToTable("NotPrefers");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.PhysicalActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Calories1min")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PhysicalActivities");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.PhysicalActivityRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ID_CaloriesRecord_PhysicalActivityRecord")
                        .HasColumnType("int");

                    b.Property<int>("ID_PhysicalActivity_PhysicalActivityRecord")
                        .HasColumnType("int");

                    b.Property<double?>("Minutes")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<DateTime?>("Time")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ID_CaloriesRecord_PhysicalActivityRecord")
                        .IsUnique();

                    b.HasIndex("ID_PhysicalActivity_PhysicalActivityRecord");

                    b.ToTable("PhysicalActivityRecords");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.PhysicalStateRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Date")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<double?>("Height")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<int>("ID_UserData_PhysicalStateRecord")
                        .HasColumnType("int");

                    b.Property<double?>("Weight")
                        .IsRequired()
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ID_UserData_PhysicalStateRecord");

                    b.ToTable("PhysicalStateRecords");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.Prefer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ID_FoodCategory_Prefer")
                        .HasColumnType("int");

                    b.Property<int>("ID_UserData")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ID_FoodCategory_Prefer");

                    b.ToTable("Prefers");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "0efbfa12-0aba-4480-a2f1-1ca6588f9e2b",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "07d6e17b-6bd4-40bb-bc9a-b63e549a5369",
                            Name = "user",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("FitnessApp.Database.Models.StepsRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("Date")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("ID_CaloriesRecord_StepsRecord")
                        .HasColumnType("int");

                    b.Property<int?>("Steps")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ID_CaloriesRecord_StepsRecord")
                        .IsUnique();

                    b.ToTable("StepsRecords");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("RememberPassword")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("FitnessApp.Database.Models.UserData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Userdata");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.WeightLossGoal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Calories")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<double?>("EndWeight")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<int>("ID_UserData_WeightLossGoal")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<double?>("StartWeight")
                        .IsRequired()
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ID_UserData_WeightLossGoal");

                    b.ToTable("WeightLossGoals");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FitnessApp.Database.Models.AppliesTo", b =>
                {
                    b.HasOne("FitnessApp.Database.Models.FoodProduct", "FoodProductObj")
                        .WithMany("AppliesTos")
                        .HasForeignKey("ID_FoodProduct_AppliesTo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodProductObj");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.CaloriesRecord", b =>
                {
                    b.HasOne("FitnessApp.Database.Models.UserData", "UserDataObj")
                        .WithMany("CaloriesRecords")
                        .HasForeignKey("ID_UserData_CaloriesRecord")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserDataObj");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.CanHave", b =>
                {
                    b.HasOne("FitnessApp.Database.Models.FoodAllergy", "FoodAllergyObj")
                        .WithMany("CanHaves")
                        .HasForeignKey("ID_FoodAllergy_CanHAve")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodAllergyObj");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.ContainsProd", b =>
                {
                    b.HasOne("FitnessApp.Database.Models.FoodProduct", "FoodProductObj")
                        .WithMany("ContainsProds")
                        .HasForeignKey("ID_FoodProduct_ContainsProd")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodProductObj");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.Diet", b =>
                {
                    b.HasOne("FitnessApp.Database.Models.WeightLossGoal", "WeightLossGoalObj")
                        .WithMany("Diets")
                        .HasForeignKey("ID_WeightLossGoal_Diet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WeightLossGoalObj");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.EatingActivityRecord", b =>
                {
                    b.HasOne("FitnessApp.Database.Models.Diet", null)
                        .WithMany("EatingActivityRecords")
                        .HasForeignKey("DietId");

                    b.HasOne("FitnessApp.Database.Models.CaloriesRecord", "CaloriesRecordObj")
                        .WithOne("EatingActivityRecord")
                        .HasForeignKey("FitnessApp.Database.Models.EatingActivityRecord", "ID_CaloriesRecord_EatingActivityRecord");

                    b.HasOne("FitnessApp.Database.Models.FoodProduct", "FoodProductObj")
                        .WithMany("EatingActivityRecords")
                        .HasForeignKey("ID_FoodProduct_EatingActivityRecord");

                    b.Navigation("CaloriesRecordObj");

                    b.Navigation("FoodProductObj");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.FoodCategory", b =>
                {
                    b.HasOne("FitnessApp.Database.Models.FoodCategory", "FoodCategoryObj")
                        .WithMany("ID_FoodCategoryNav_Inv")
                        .HasForeignKey("ID_FoodCategory_FoodCategory");

                    b.Navigation("FoodCategoryObj");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.NotPrefer", b =>
                {
                    b.HasOne("FitnessApp.Database.Models.FoodCategory", "FoodCategoryObj")
                        .WithMany("NotPrefers")
                        .HasForeignKey("ID_FoodCategory_NotPrefer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodCategoryObj");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.PhysicalActivityRecord", b =>
                {
                    b.HasOne("FitnessApp.Database.Models.CaloriesRecord", "CaloriesRecordObj")
                        .WithOne("PhysicalActivityRecord")
                        .HasForeignKey("FitnessApp.Database.Models.PhysicalActivityRecord", "ID_CaloriesRecord_PhysicalActivityRecord")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessApp.Database.Models.PhysicalActivity", "PhysicalActivityObj")
                        .WithMany("PhysicalActivityRecords")
                        .HasForeignKey("ID_PhysicalActivity_PhysicalActivityRecord")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CaloriesRecordObj");

                    b.Navigation("PhysicalActivityObj");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.PhysicalStateRecord", b =>
                {
                    b.HasOne("FitnessApp.Database.Models.UserData", "UserDataObj")
                        .WithMany("PhysicalStateRecords")
                        .HasForeignKey("ID_UserData_PhysicalStateRecord")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserDataObj");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.Prefer", b =>
                {
                    b.HasOne("FitnessApp.Database.Models.FoodCategory", "FoodCategoryObj")
                        .WithMany("Prefers")
                        .HasForeignKey("ID_FoodCategory_Prefer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodCategoryObj");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.StepsRecord", b =>
                {
                    b.HasOne("FitnessApp.Database.Models.CaloriesRecord", "CaloriesRecordObj")
                        .WithOne("StepsRecord")
                        .HasForeignKey("FitnessApp.Database.Models.StepsRecord", "ID_CaloriesRecord_StepsRecord")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CaloriesRecordObj");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.WeightLossGoal", b =>
                {
                    b.HasOne("FitnessApp.Database.Models.UserData", "UserDataObj")
                        .WithMany("WeightLossGoals")
                        .HasForeignKey("ID_UserData_WeightLossGoal")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserDataObj");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("FitnessApp.Database.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("FitnessApp.Database.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("FitnessApp.Database.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("FitnessApp.Database.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessApp.Database.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("FitnessApp.Database.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FitnessApp.Database.Models.CaloriesRecord", b =>
                {
                    b.Navigation("EatingActivityRecord")
                        .IsRequired();

                    b.Navigation("PhysicalActivityRecord")
                        .IsRequired();

                    b.Navigation("StepsRecord")
                        .IsRequired();
                });

            modelBuilder.Entity("FitnessApp.Database.Models.Diet", b =>
                {
                    b.Navigation("EatingActivityRecords");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.FoodAllergy", b =>
                {
                    b.Navigation("CanHaves");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.FoodCategory", b =>
                {
                    b.Navigation("ID_FoodCategoryNav_Inv");

                    b.Navigation("NotPrefers");

                    b.Navigation("Prefers");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.FoodProduct", b =>
                {
                    b.Navigation("AppliesTos");

                    b.Navigation("ContainsProds");

                    b.Navigation("EatingActivityRecords");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.PhysicalActivity", b =>
                {
                    b.Navigation("PhysicalActivityRecords");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.UserData", b =>
                {
                    b.Navigation("CaloriesRecords");

                    b.Navigation("PhysicalStateRecords");

                    b.Navigation("WeightLossGoals");
                });

            modelBuilder.Entity("FitnessApp.Database.Models.WeightLossGoal", b =>
                {
                    b.Navigation("Diets");
                });
#pragma warning restore 612, 618
        }
    }
}
