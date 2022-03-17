using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class ContainsProd
    {
        public int FkFoodProductidFoodProduct { get; set; }
        public int FkFoodCategoryidFoodCategory { get; set; }

        public virtual FoodProduct FkFoodProductidFoodProductNavigation { get; set; } = null!;
    }
}
