using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FitnessApp.Database.Models
{
    public partial class FitnessAppDbContext : DbContext
    {
        public readonly string connectionName = "FitnessAppDatabase";
        public FitnessAppDbContext(string connName = "FitnessAppDatabase")
        {
            connName = connectionName;
        }

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
                optionsBuilder.UseSqlServer(connectionName);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppliesTo>(entity =>
            {
                entity.HasKey(e => new { e.ID_FoodProduct, e.ID_FoodAllergy })
                    .HasName("AppliesTo");

                entity.ToTable("appliesTo");

                entity.Property(e => e.ID_FoodProduct).HasColumnName("ID_FoodProduct");

                entity.Property(e => e.ID_FoodAllergy).HasColumnName("ID_FoodAllergy");

                entity.HasOne(d => d.ID_FoodProductNav)
                    .WithMany(p => p.AppliesTos)
                    .HasForeignKey(d => d.ID_FoodProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("appliesToFood");
            });

            modelBuilder.Entity<CaloriesRecord>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("CaloriesRecord");

                entity.ToTable("CALORIES_RECORD");

                entity.Property(e => e.ID)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChangeInCalories).HasColumnName("change_in_calories");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.ID_UserData).HasColumnName("ID_UserData");

                entity.HasOne(d => d.ID_UserDataNav)
                    .WithMany(p => p.CaloriesRecords)
                    .HasForeignKey(d => d.ID_UserData)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("providesCal");
            });

            modelBuilder.Entity<CanHave>(entity =>
            {
                entity.HasKey(e => new { e.ID_FoodAllergy, e.ID_UserData })
                    .HasName("CanHave");

                entity.ToTable("canHave");

                entity.Property(e => e.ID_FoodAllergy).HasColumnName("ID_FoodAllergy");

                entity.Property(e => e.ID_UserData).HasColumnName("ID_UserData");

                entity.HasOne(d => d.ID_FoodAllergyNav)
                    .WithMany(p => p.CanHaves)
                    .HasForeignKey(d => d.ID_FoodAllergy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("canHaveAller");
            });

            modelBuilder.Entity<ContainsProd>(entity =>
            {
                entity.HasKey(e => new { e.ID_FoodProduct, e.ID_FoodCategory })
                    .HasName("ContainsProd");

                entity.ToTable("containsProd");

                entity.Property(e => e.ID_FoodProduct).HasColumnName("ID_FoodProduct");

                entity.Property(e => e.ID_FoodCategory).HasColumnName("ID_FoodCategory");

                entity.HasOne(d => d.ID_FoodProductNav)
                    .WithMany(p => p.ContainsProds)
                    .HasForeignKey(d => d.ID_FoodProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("contProd");
            });

            modelBuilder.Entity<Diet>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("Diet");

                entity.ToTable("DIET");

                entity.Property(e => e.ID)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ID_WeightLossGoal).HasColumnName("ID_WeightLossGoal");

                entity.HasOne(d => d.ID_WeightLossGoalNav)
                    .WithMany(p => p.Diets)
                    .HasForeignKey(d => d.ID_WeightLossGoal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("containsDiet");
            });

            modelBuilder.Entity<EatingActivityRecord>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("EatingActivityRecord");

                entity.ToTable("EATING_ACTIVITY_RECORD");

                entity.HasIndex(e => e.ID_CaloriesRecord, "ID_Unique")
                    .IsUnique();

                entity.Property(e => e.ID)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ID_CaloriesRecord).HasColumnName("ID_CaloriesRecord");

                entity.Property(e => e.ID_Diet).HasColumnName("ID_Diet");

                entity.Property(e => e.ID_FoodProduct).HasColumnName("ID_FoodProduct");

                entity.Property(e => e.Grams).HasColumnName("grams");

                entity.HasOne(d => d.ID_CaloriesRecordNav)
                    .WithOne(p => p.EatingActivityRecord)
                    .HasForeignKey<EatingActivityRecord>(d => d.ID_CaloriesRecord)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("providesEatAct");

                entity.HasOne(d => d.ID_DietNav)
                    .WithMany(p => p.EatingActivityRecords)
                    .HasForeignKey(d => d.ID_Diet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("includesAct");

                entity.HasOne(d => d.ID_FoodProductNav)
                    .WithMany(p => p.EatingActivityRecords)
                    .HasForeignKey(d => d.ID_FoodProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("containsFood");
            });

            modelBuilder.Entity<FoodAllergy>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("FoodAllergy");

                entity.ToTable("FOOD_ALLERGY");

                entity.Property(e => e.ID)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<FoodCategory>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("FoodCategory");

                entity.ToTable("FOOD_CATEGORY");

                entity.Property(e => e.ID)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ID_FoodCategory).HasColumnName("ID_FoodCategory");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.ID_FoodCategoryNav)
                    .WithMany(p => p.ID_FoodCategoryNav_Inv)
                    .HasForeignKey(d => d.ID_FoodCategory)
                    .HasConstraintName("hasSubcat");
            });

            modelBuilder.Entity<FoodProduct>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("FoodProduct");

                entity.ToTable("FOOD_PRODUCT");

                entity.Property(e => e.ID)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Calories100g).HasColumnName("calories100g");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("imageURL");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<NotPrefer>(entity =>
            {
                entity.HasKey(e => new { e.ID_FoodCategory, e.ID_UserData })
                    .HasName("NotPrefer");

                entity.ToTable("notPrefer");

                entity.Property(e => e.ID_FoodCategory).HasColumnName("ID_FoodCategory");

                entity.Property(e => e.ID_UserData).HasColumnName("ID_UserData");

                entity.HasOne(d => d.ID_FoodCategoryNav)
                    .WithMany(p => p.NotPrefers)
                    .HasForeignKey(d => d.ID_FoodCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("notPref");
            });

            modelBuilder.Entity<PhysicalActivity>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PhysicalActivity");

                entity.ToTable("PHYSICAL_ACTIVITY");

                entity.Property(e => e.ID)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Calories1min).HasColumnName("calories1min");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<PhysicalActivityRecord>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PhysicalActivityRecord");

                entity.ToTable("PHYSICAL_ACTIVITY_RECORD");

                entity.HasIndex(e => e.ID_CaloriesRecord, "ID_Unique")
                    .IsUnique();

                entity.Property(e => e.ID)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ID_CaloriesRecord).HasColumnName("ID_CaloriesRecord");

                entity.Property(e => e.ID_PhysicalActivity).HasColumnName("ID_PhysicalActivity");

                entity.Property(e => e.Minutes).HasColumnName("minutes");

                entity.Property(e => e.Time)
                    .HasColumnType("date")
                    .HasColumnName("time");

                entity.HasOne(d => d.ID_CaloriesRecordNav)
                    .WithOne(p => p.PhysicalActivityRecord)
                    .HasForeignKey<PhysicalActivityRecord>(d => d.ID_CaloriesRecord)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("providesPhysAct");

                entity.HasOne(d => d.ID_PhysicalActivityNav)
                    .WithMany(p => p.PhysicalActivityRecords)
                    .HasForeignKey(d => d.ID_PhysicalActivity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("performsPhys");
            });

            modelBuilder.Entity<PhysicalStateRecord>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("PhysicalStateRecord");

                entity.ToTable("PHYSICAL_STATE_RECORD");

                entity.Property(e => e.ID)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.ID_UserData).HasColumnName("ID_UserData");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.ID_UserDataNav)
                    .WithMany(p => p.PhysicalStateRecords)
                    .HasForeignKey(d => d.ID_UserData)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("providesPhysState");
            });

            modelBuilder.Entity<Prefer>(entity =>
            {
                entity.HasKey(e => new { e.ID_FoodCategory, e.ID_UserData })
                    .HasName("Prefer");

                entity.ToTable("prefer");

                entity.Property(e => e.ID_FoodCategory).HasColumnName("ID_FoodCategory");

                entity.Property(e => e.ID_UserData).HasColumnName("ID_UserData");

                entity.HasOne(d => d.ID_FoodCategoryNav)
                    .WithMany(p => p.Prefers)
                    .HasForeignKey(d => d.ID_FoodCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pref");
            });

            modelBuilder.Entity<StepsRecord>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("StepsRecord");

                entity.ToTable("STEPS_RECORD");

                entity.HasIndex(e => e.ID_CaloriesRecord, "ID_Unique")
                    .IsUnique();

                entity.Property(e => e.ID)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.ID_CaloriesRecord).HasColumnName("ID_CaloriesRecord");

                entity.Property(e => e.Steps).HasColumnName("steps");

                entity.HasOne(d => d.ID_CaloriesRecordNav)
                    .WithOne(p => p.StepsRecord)
                    .HasForeignKey<StepsRecord>(d => d.ID_CaloriesRecord)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("providesSteps");
            });

            modelBuilder.Entity<UserData>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("UserData");

                entity.ToTable("USERDATA");

                entity.Property(e => e.ID)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("last_name");
            });

            modelBuilder.Entity<WeightLossGoal>(entity =>
            {
                entity.HasKey(e => e.ID)
                    .HasName("WeightLossGoal");

                entity.ToTable("WEIGHT_LOSS_GOAL");

                entity.Property(e => e.ID)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Calories).HasColumnName("calories");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.EndWeight).HasColumnName("end_weight");

                entity.Property(e => e.ID_UserData).HasColumnName("ID_UserData");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.StartWeight).HasColumnName("start_weight");

                entity.HasOne(d => d.ID_UserDataNav)
                    .WithMany(p => p.WeightLossGoals)
                    .HasForeignKey(d => d.ID_UserData)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("creates");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
