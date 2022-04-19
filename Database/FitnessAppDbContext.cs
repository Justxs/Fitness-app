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
        public virtual DbSet<Userdatum> Userdata { get; set; } = null!;
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
                entity.HasKey(e => new { e.FkFoodProductidFoodProduct, e.FkFoodAllergyidFoodAllergy })
                    .HasName("PK__appliesT__6A1AFE573F5E5A40");

                entity.ToTable("appliesTo");

                entity.Property(e => e.FkFoodProductidFoodProduct).HasColumnName("fk_FOOD_PRODUCTid_FOOD_PRODUCT");

                entity.Property(e => e.FkFoodAllergyidFoodAllergy).HasColumnName("fk_FOOD_ALLERGYid_FOOD_ALLERGY");

                entity.HasOne(d => d.FkFoodProductidFoodProductNavigation)
                    .WithMany(p => p.AppliesTos)
                    .HasForeignKey(d => d.FkFoodProductidFoodProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("appliesToFood");
            });

            modelBuilder.Entity<CaloriesRecord>(entity =>
            {
                entity.HasKey(e => e.IdCaloriesRecord)
                    .HasName("PK__CALORIES__B2F3B2B2D9A41565");

                entity.ToTable("CALORIES_RECORD");

                entity.Property(e => e.IdCaloriesRecord)
                    .ValueGeneratedNever()
                    .HasColumnName("id_CALORIES_RECORD");

                entity.Property(e => e.ChangeInCalories).HasColumnName("change_in_calories");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.FkUserdataidUserdata).HasColumnName("fk_USERDATAid_USERDATA");

                entity.HasOne(d => d.FkUserdataidUserdataNavigation)
                    .WithMany(p => p.CaloriesRecords)
                    .HasForeignKey(d => d.FkUserdataidUserdata)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("providesCal");
            });

            modelBuilder.Entity<CanHave>(entity =>
            {
                entity.HasKey(e => new { e.FkFoodAllergyidFoodAllergy, e.FkUserdataidUserdata })
                    .HasName("PK__canHave__91FB896E5CC02FD3");

                entity.ToTable("canHave");

                entity.Property(e => e.FkFoodAllergyidFoodAllergy).HasColumnName("fk_FOOD_ALLERGYid_FOOD_ALLERGY");

                entity.Property(e => e.FkUserdataidUserdata).HasColumnName("fk_USERDATAid_USERDATA");

                entity.HasOne(d => d.FkFoodAllergyidFoodAllergyNavigation)
                    .WithMany(p => p.CanHaves)
                    .HasForeignKey(d => d.FkFoodAllergyidFoodAllergy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("canHaveAller");
            });

            modelBuilder.Entity<ContainsProd>(entity =>
            {
                entity.HasKey(e => new { e.FkFoodProductidFoodProduct, e.FkFoodCategoryidFoodCategory })
                    .HasName("PK__contains__BA9B07CDC75C3D6D");

                entity.ToTable("containsProd");

                entity.Property(e => e.FkFoodProductidFoodProduct).HasColumnName("fk_FOOD_PRODUCTid_FOOD_PRODUCT");

                entity.Property(e => e.FkFoodCategoryidFoodCategory).HasColumnName("fk_FOOD_CATEGORYid_FOOD_CATEGORY");

                entity.HasOne(d => d.FkFoodProductidFoodProductNavigation)
                    .WithMany(p => p.ContainsProds)
                    .HasForeignKey(d => d.FkFoodProductidFoodProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("contProd");
            });

            modelBuilder.Entity<Diet>(entity =>
            {
                entity.HasKey(e => e.IdDiet)
                    .HasName("PK__DIET__4F94AA8EFA640032");

                entity.ToTable("DIET");

                entity.Property(e => e.IdDiet)
                    .ValueGeneratedNever()
                    .HasColumnName("id_DIET");

                entity.Property(e => e.FkWeightLossGoalidWeightLossGoal).HasColumnName("fk_WEIGHT_LOSS_GOALid_WEIGHT_LOSS_GOAL");

                entity.HasOne(d => d.FkWeightLossGoalidWeightLossGoalNavigation)
                    .WithMany(p => p.Diets)
                    .HasForeignKey(d => d.FkWeightLossGoalidWeightLossGoal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("containsDiet");
            });

            modelBuilder.Entity<EatingActivityRecord>(entity =>
            {
                entity.HasKey(e => e.IdEatingActivityRecord)
                    .HasName("PK__EATING_A__0EEDC8DD4B24DB61");

                entity.ToTable("EATING_ACTIVITY_RECORD");

                entity.HasIndex(e => e.FkCaloriesRecordidCaloriesRecord, "UQ__EATING_A__3AF787A69979C5F8")
                    .IsUnique();

                entity.Property(e => e.IdEatingActivityRecord)
                    .ValueGeneratedNever()
                    .HasColumnName("id_EATING_ACTIVITY_RECORD");

                entity.Property(e => e.FkCaloriesRecordidCaloriesRecord).HasColumnName("fk_CALORIES_RECORDid_CALORIES_RECORD");

                entity.Property(e => e.FkDietidDiet).HasColumnName("fk_DIETid_DIET");

                entity.Property(e => e.FkFoodProductidFoodProduct).HasColumnName("fk_FOOD_PRODUCTid_FOOD_PRODUCT");

                entity.Property(e => e.Grams).HasColumnName("grams");

                entity.HasOne(d => d.FkCaloriesRecordidCaloriesRecordNavigation)
                    .WithOne(p => p.EatingActivityRecord)
                    .HasForeignKey<EatingActivityRecord>(d => d.FkCaloriesRecordidCaloriesRecord)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("providesEatAct");

                entity.HasOne(d => d.FkDietidDietNavigation)
                    .WithMany(p => p.EatingActivityRecords)
                    .HasForeignKey(d => d.FkDietidDiet)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("includesAct");

                entity.HasOne(d => d.FkFoodProductidFoodProductNavigation)
                    .WithMany(p => p.EatingActivityRecords)
                    .HasForeignKey(d => d.FkFoodProductidFoodProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("containsFood");
            });

            modelBuilder.Entity<FoodAllergy>(entity =>
            {
                entity.HasKey(e => e.IdFoodAllergy)
                    .HasName("PK__FOOD_ALL__E61CD263D937A79A");

                entity.ToTable("FOOD_ALLERGY");

                entity.Property(e => e.IdFoodAllergy)
                    .ValueGeneratedNever()
                    .HasColumnName("id_FOOD_ALLERGY");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<FoodCategory>(entity =>
            {
                entity.HasKey(e => e.IdFoodCategory)
                    .HasName("PK__FOOD_CAT__A8F642208AC127BC");

                entity.ToTable("FOOD_CATEGORY");

                entity.Property(e => e.IdFoodCategory)
                    .ValueGeneratedNever()
                    .HasColumnName("id_FOOD_CATEGORY");

                entity.Property(e => e.FkFoodCategoryidFoodCategory).HasColumnName("fk_FOOD_CATEGORYid_FOOD_CATEGORY");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.FkFoodCategoryidFoodCategoryNavigation)
                    .WithMany(p => p.InverseFkFoodCategoryidFoodCategoryNavigation)
                    .HasForeignKey(d => d.FkFoodCategoryidFoodCategory)
                    .HasConstraintName("hasSubcat");
            });

            modelBuilder.Entity<FoodProduct>(entity =>
            {
                entity.HasKey(e => e.IdFoodProduct)
                    .HasName("PK__FOOD_PRO__E01DB2E47AC7C142");

                entity.ToTable("FOOD_PRODUCT");

                entity.Property(e => e.IdFoodProduct)
                    .ValueGeneratedNever()
                    .HasColumnName("id_FOOD_PRODUCT");

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
                entity.HasKey(e => new { e.FkFoodCategoryidFoodCategory, e.FkUserdataidUserdata })
                    .HasName("PK__notPrefe__99E410C39B7ED4D0");

                entity.ToTable("notPrefer");

                entity.Property(e => e.FkFoodCategoryidFoodCategory).HasColumnName("fk_FOOD_CATEGORYid_FOOD_CATEGORY");

                entity.Property(e => e.FkUserdataidUserdata).HasColumnName("fk_USERDATAid_USERDATA");

                entity.HasOne(d => d.FkFoodCategoryidFoodCategoryNavigation)
                    .WithMany(p => p.NotPrefers)
                    .HasForeignKey(d => d.FkFoodCategoryidFoodCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("notPref");
            });

            modelBuilder.Entity<PhysicalActivity>(entity =>
            {
                entity.HasKey(e => e.IdPhysicalActivity)
                    .HasName("PK__PHYSICAL__0747CC64DE382ACA");

                entity.ToTable("PHYSICAL_ACTIVITY");

                entity.Property(e => e.IdPhysicalActivity)
                    .ValueGeneratedNever()
                    .HasColumnName("id_PHYSICAL_ACTIVITY");

                entity.Property(e => e.Calories1min).HasColumnName("calories1min");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<PhysicalActivityRecord>(entity =>
            {
                entity.HasKey(e => e.IdPhysicalActivityRecord)
                    .HasName("PK__PHYSICAL__196E84DD59207038");

                entity.ToTable("PHYSICAL_ACTIVITY_RECORD");

                entity.HasIndex(e => e.FkCaloriesRecordidCaloriesRecord, "UQ__PHYSICAL__3AF787A675E9DBD0")
                    .IsUnique();

                entity.Property(e => e.IdPhysicalActivityRecord)
                    .ValueGeneratedNever()
                    .HasColumnName("id_PHYSICAL_ACTIVITY_RECORD");

                entity.Property(e => e.FkCaloriesRecordidCaloriesRecord).HasColumnName("fk_CALORIES_RECORDid_CALORIES_RECORD");

                entity.Property(e => e.FkPhysicalActivityidPhysicalActivity).HasColumnName("fk_PHYSICAL_ACTIVITYid_PHYSICAL_ACTIVITY");

                entity.Property(e => e.Minutes).HasColumnName("minutes");

                entity.Property(e => e.Time)
                    .HasColumnType("date")
                    .HasColumnName("time");

                entity.HasOne(d => d.FkCaloriesRecordidCaloriesRecordNavigation)
                    .WithOne(p => p.PhysicalActivityRecord)
                    .HasForeignKey<PhysicalActivityRecord>(d => d.FkCaloriesRecordidCaloriesRecord)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("providesPhysAct");

                entity.HasOne(d => d.FkPhysicalActivityidPhysicalActivityNavigation)
                    .WithMany(p => p.PhysicalActivityRecords)
                    .HasForeignKey(d => d.FkPhysicalActivityidPhysicalActivity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("performsPhys");
            });

            modelBuilder.Entity<PhysicalStateRecord>(entity =>
            {
                entity.HasKey(e => e.IdPhysicalStateRecord)
                    .HasName("PK__PHYSICAL__00CA2CAF11978215");

                entity.ToTable("PHYSICAL_STATE_RECORD");

                entity.Property(e => e.IdPhysicalStateRecord)
                    .ValueGeneratedNever()
                    .HasColumnName("id_PHYSICAL_STATE_RECORD");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.FkUserdataidUserdata).HasColumnName("fk_USERDATAid_USERDATA");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.FkUserdataidUserdataNavigation)
                    .WithMany(p => p.PhysicalStateRecords)
                    .HasForeignKey(d => d.FkUserdataidUserdata)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("providesPhysState");
            });

            modelBuilder.Entity<Prefer>(entity =>
            {
                entity.HasKey(e => new { e.FkFoodCategoryidFoodCategory, e.FkUserdataidUserdata })
                    .HasName("PK__prefer__99E410C358EABD0E");

                entity.ToTable("prefer");

                entity.Property(e => e.FkFoodCategoryidFoodCategory).HasColumnName("fk_FOOD_CATEGORYid_FOOD_CATEGORY");

                entity.Property(e => e.FkUserdataidUserdata).HasColumnName("fk_USERDATAid_USERDATA");

                entity.HasOne(d => d.FkFoodCategoryidFoodCategoryNavigation)
                    .WithMany(p => p.Prefers)
                    .HasForeignKey(d => d.FkFoodCategoryidFoodCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pref");
            });

            modelBuilder.Entity<StepsRecord>(entity =>
            {
                entity.HasKey(e => e.IdStepsRecord)
                    .HasName("PK__STEPS_RE__71DCAA1F0A0DA24D");

                entity.ToTable("STEPS_RECORD");

                entity.HasIndex(e => e.FkCaloriesRecordidCaloriesRecord, "UQ__STEPS_RE__3AF787A675A5E5FE")
                    .IsUnique();

                entity.Property(e => e.IdStepsRecord)
                    .ValueGeneratedNever()
                    .HasColumnName("id_STEPS_RECORD");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.FkCaloriesRecordidCaloriesRecord).HasColumnName("fk_CALORIES_RECORDid_CALORIES_RECORD");

                entity.Property(e => e.Steps).HasColumnName("steps");

                entity.HasOne(d => d.FkCaloriesRecordidCaloriesRecordNavigation)
                    .WithOne(p => p.StepsRecord)
                    .HasForeignKey<StepsRecord>(d => d.FkCaloriesRecordidCaloriesRecord)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("providesSteps");
            });

            modelBuilder.Entity<Userdatum>(entity =>
            {
                entity.HasKey(e => e.IdUserdata)
                    .HasName("PK__USERDATA__9248BFF4F95D1C00");

                entity.ToTable("USERDATA");

                entity.Property(e => e.IdUserdata)
                    .ValueGeneratedNever()
                    .HasColumnName("id_USERDATA");

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
                entity.HasKey(e => e.IdWeightLossGoal)
                    .HasName("PK__WEIGHT_L__D72EF27FBC8B6B59");

                entity.ToTable("WEIGHT_LOSS_GOAL");

                entity.Property(e => e.IdWeightLossGoal)
                    .ValueGeneratedNever()
                    .HasColumnName("id_WEIGHT_LOSS_GOAL");

                entity.Property(e => e.Calories).HasColumnName("calories");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.EndWeight).HasColumnName("end_weight");

                entity.Property(e => e.FkUserdataidUserdata).HasColumnName("fk_USERDATAid_USERDATA");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date");

                entity.Property(e => e.StartWeight).HasColumnName("start_weight");

                entity.HasOne(d => d.FkUserdataidUserdataNavigation)
                    .WithMany(p => p.WeightLossGoals)
                    .HasForeignKey(d => d.FkUserdataidUserdata)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("creates");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
