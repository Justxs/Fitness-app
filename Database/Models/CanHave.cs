using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class CanHave
    {
        public int FkFoodAllergyidFoodAllergy { get; set; }
        public int FkUserdataidUserdata { get; set; }

        public virtual FoodAllergy FkFoodAllergyidFoodAllergyNavigation { get; set; } = null!;
    }
}
