using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class AppliesTo
    {
        public int FkFoodProductidFoodProduct { get; set; }
        public int FkFoodAllergyidFoodAllergy { get; set; }

        public virtual FoodProduct FkFoodProductidFoodProductNavigation { get; set; } = null!;
    }
}
