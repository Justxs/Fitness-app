using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class FoodCategory
    {
        public FoodCategory()
        {
            InverseFkFoodCategoryidFoodCategoryNavigation = new HashSet<FoodCategory>();
            NotPrefers = new HashSet<NotPrefer>();
            Prefers = new HashSet<Prefer>();
        }

        public string? Name { get; set; }
        public int IdFoodCategory { get; set; }
        public int? FkFoodCategoryidFoodCategory { get; set; }

        public virtual FoodCategory? FkFoodCategoryidFoodCategoryNavigation { get; set; }
        public virtual ICollection<FoodCategory> InverseFkFoodCategoryidFoodCategoryNavigation { get; set; }
        public virtual ICollection<NotPrefer> NotPrefers { get; set; }
        public virtual ICollection<Prefer> Prefers { get; set; }
    }
}
