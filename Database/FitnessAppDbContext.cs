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

        public virtual DbSet<AppliesTo> AppliesTos { get; set; } = null!;
        public virtual DbSet<CaloriesRecord> CaloriesRecords { get; set; } = null!;
        public virtual DbSet<CanHave> CanHaves { get; set; } = null!;
        public virtual DbSet<ContainsProd> ContainsProds { get; set; } = null!;
        public virtual DbSet<Diet> Diets { get; set; } = null!;
        public virtual DbSet<EatingActivityRecord> EatingActivityRecords { get; set; } = null!;
        public virtual DbSet<FoodAllergy> FoodAllergies { get; set; } = null!;
        public virtual DbSet<FoodCategory> FoodCategories { get; set; } = null!;
        public virtual DbSet<FoodProduct> FoodProducts { get; set; } = null!;
        public virtual DbSet<NotPrefer> NotPrefers { get; set; } = null!;
        public virtual DbSet<PhysicalActivity> PhysicalActivities { get; set; } = null!;
        public virtual DbSet<PhysicalActivityRecord> PhysicalActivityRecords { get; set; } = null!;
        public virtual DbSet<PhysicalStateRecord> PhysicalStateRecords { get; set; } = null!;
        public virtual DbSet<Prefer> Prefers { get; set; } = null!;
        public virtual DbSet<StepsRecord> StepsRecords { get; set; } = null!;
        public virtual DbSet<UserData> Userdata { get; set; } = null!;
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
            modelBuilder.Entity<FoodProduct>().HasData(new FoodProduct(1, "Steak", 15, 65.2f, 4.9f, 364.9f, ""),
                                                       new FoodProduct(2, "Whole grain bread",6.98f,37.2f,1.16f,209.3f,""),
                                                       new FoodProduct(3, "Pineapple Pizza",9.4f,30.2f,8.1f,230.1f,""),
                                                       new FoodProduct(4, "Milk",3.3f,4.9f,2f,50f,""));

            modelBuilder.Entity<Role>().HasData(new Role(1, "admin"),
                                                new Role(2, "user"));
            //PASSWORD: String123!
            modelBuilder.Entity<User>().HasData(new User(1, "Admy", "Nisterson", true, "admin@admin.com", "admin@admin.com", false, "AQAAAAEAACcQAAAAEMHhI7bKcvc+OSmYucr/dU7cRoCREp11U+oibZKHL4MGRUELRPwOVofNqZkOjty5Jw==", "BOQD6BFFLWPX7GNRBP7ITK5DUCYFVMUF", "86a67702-8c7f-4880-b807-5de43c2fc135"),
                                                new User(2, "Usy", "Erson", true, "user@example.com", "user@example.com", false, "AQAAAAEAACcQAAAAEMHhI7bKcvc+OSmYucr/dU7cRoCREp11U+oibZKHL4MGRUELRPwOVofNqZkOjty5Jw==", "HKUSLCZJDZ6YJEVU32KEIPBXCDQNO3OK", "499c1393-4898-482b-9747-c0c8b8f0abac"));

            IdentityUserRole<int> role1 = new IdentityUserRole<int>(), role2 = new IdentityUserRole<int>();
            role1.UserId = 1;
            role1.RoleId = 1;
            role2.UserId = 2;
            role2.RoleId = 2;
            modelBuilder.Entity<IdentityUserRole<int>>().HasData(role1, role2);


            base.OnModelCreating(modelBuilder);
        }
    }
}
