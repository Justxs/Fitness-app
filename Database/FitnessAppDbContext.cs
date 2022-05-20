using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FitnessApp.Database.Models
{
    public partial class FitnessAppDbContext : IdentityDbContext<User,Role,int>
    {
        public readonly string connectionName = "FitnessAppDatabase";
        
        public FitnessAppDbContext(DbContextOptions<FitnessAppDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<FoodRecord> FoodRecords { get; set; } = null!;
        public virtual DbSet<PhysicalStateRecord> PhysicalStateRecords { get; set; } = null!;
        public virtual DbSet<WeightLossGoal> WeightLossGoals { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connectionString = configuration.GetConnectionString("TrustedConnection");
                optionsBuilder.UseSqlServer(connectionName);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodRecord>().HasData(new FoodRecord { Id = 1, Name = "Steak", Proteins = 15, Carbohydrates = 65.2f, Fats = 4.9f, Calories = 364.9f, ImageUrl = "", UserId = 2, Date = DateTime.Now },
                                           new FoodRecord { Id = 2, Name = "Whole grain bread", Proteins = 6.98f, Carbohydrates = 37.2f, Fats = 1.16f, Calories = 209.3f, ImageUrl = "", UserId = 2, Date = DateTime.Now },
                                           new FoodRecord { Id = 3, Name = "Pineapple Pizza", Proteins = 9.4f, Carbohydrates = 30.2f, Fats = 8.1f, Calories = 230.1f, ImageUrl = "", UserId = 2, Date = new DateTime(2022, 05, 19, 04, 21, 00) },
                                           new FoodRecord { Id = 4, Name = "Milk", Proteins = 3.3f, Carbohydrates = 4.9f, Fats = 2f, Calories = 50f, ImageUrl = "", UserId = 2, Date = DateTime.Now });

            modelBuilder.Entity<Role>().HasData(new Role { Id = 1, Name = "admin", NormalizedName = "Admin"},
                                                new Role { Id = 2, Name = "user", NormalizedName = "USER"});
            //PASSWORD: String123!
            modelBuilder.Entity<User>().HasData(new User { Id = 1, FirstName = "Admy", LastName = "Nisterson", RememberPassword = true, UserName = "admin@admin.com",NormalizedUserName = "ADMIN@ADMIN.COM", Email = "admin@admin.com",NormalizedEmail = "ADMIN@ADMIN.COM" , EmailConfirmed = true, PasswordHash = "AQAAAAEAACcQAAAAEMHhI7bKcvc+OSmYucr/dU7cRoCREp11U+oibZKHL4MGRUELRPwOVofNqZkOjty5Jw==", SecurityStamp = "BOQD6BFFLWPX7GNRBP7ITK5DUCYFVMUF", ConcurrencyStamp = "86a67702-8c7f-4880-b807-5de43c2fc135", PhoneNumber = null, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = false, LockoutEnd = null },
                                                new User { Id = 2, FirstName = "Usy", LastName = "Erson", RememberPassword = true, UserName = "user@example.com", NormalizedUserName = "USER@EXAMPLE.COM", Email = "user@example.com", NormalizedEmail = "USER@EXAMPLE.COM", EmailConfirmed = true, PasswordHash = "AQAAAAEAACcQAAAAEMHhI7bKcvc+OSmYucr/dU7cRoCREp11U+oibZKHL4MGRUELRPwOVofNqZkOjty5Jw==", SecurityStamp = "BOQD6BFFLWPX7GNRBP7ITK5DUCYFVMUF", ConcurrencyStamp = "86a67702-8c7f-4880-b807-5de43c2fc135", PhoneNumber = null, PhoneNumberConfirmed = false, TwoFactorEnabled = false, LockoutEnabled = false, LockoutEnd = null });

            modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int> { UserId = 1, RoleId = 1},
                                                                 new IdentityUserRole<int> { UserId = 2, RoleId = 2});

            base.OnModelCreating(modelBuilder);
        }
    }
}
