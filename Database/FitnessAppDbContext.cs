using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FitnessApp.Database.Models
{
    public partial class FitnessAppDbContext : DbContext
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
        }
    }
}
