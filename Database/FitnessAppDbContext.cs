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
            
        }
    }
}
