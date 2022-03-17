using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class NotPrefer
    {
        public int FkFoodCategoryidFoodCategory { get; set; }
        public int FkUserdataidUserdata { get; set; }

        public virtual FoodCategory FkFoodCategoryidFoodCategoryNavigation { get; set; } = null!;
    }
}
