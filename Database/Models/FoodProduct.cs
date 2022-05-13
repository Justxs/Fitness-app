using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Database.Models
{
    public partial class FoodProduct: ID
    {
        public FoodProduct(int id, string name, float proteins100g, float carbohydrates100g, float fats100g, float calories100g, string imageUrl = "")
        {
            AppliesTos = new HashSet<AppliesTo>();
            ContainsProds = new HashSet<ContainsProd>();
            EatingActivityRecords = new HashSet<EatingActivityRecord>();
            this.Id = id;
            this.Name = name;
            this.Proteins100g = proteins100g;
            this.Carbohydrates100g = carbohydrates100g;
            this.Fats100g = fats100g;
            this.Calories100g = calories100g;
            this.ImageUrl = imageUrl;
        }
        [Required]
        public string Name { get; set; }
        [Required]
        public float Proteins100g { get; set; }

        [Required]
        public float Carbohydrates100g { get; set; }

        [Required]
        public float Fats100g { get; set; }
        [Required]
        public float Calories100g { get; set; }
        public string? ImageUrl { get; set; }

        public virtual ICollection<AppliesTo> AppliesTos { get; set; }
        public virtual ICollection<ContainsProd> ContainsProds { get; set; }
        public virtual ICollection<EatingActivityRecord> EatingActivityRecords { get; set; }
    }
}
