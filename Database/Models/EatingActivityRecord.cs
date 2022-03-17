using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class EatingActivityRecord
    {
        public int? Grams { get; set; }
        public int IdEatingActivityRecord { get; set; }
        public int FkCaloriesRecordidCaloriesRecord { get; set; }
        public int FkFoodProductidFoodProduct { get; set; }
        public int FkDietidDiet { get; set; }

        public virtual CaloriesRecord FkCaloriesRecordidCaloriesRecordNavigation { get; set; } = null!;
        public virtual Diet FkDietidDietNavigation { get; set; } = null!;
        public virtual FoodProduct FkFoodProductidFoodProductNavigation { get; set; } = null!;
    }
}
