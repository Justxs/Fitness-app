using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Database.Models
{
    public partial class FoodProduct: ID
    {
        public FoodProduct()
        {
            AppliesTos = new HashSet<AppliesTo>();
            ContainsProds = new HashSet<ContainsProd>();
            EatingActivityRecords = new HashSet<EatingActivityRecord>();
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
