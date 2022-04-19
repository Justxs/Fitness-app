using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class Prefer
    {
        public int ID_FoodCategory { get; set; }
        public int ID_UserData { get; set; }

        public virtual FoodCategory ID_FoodCategoryNav { get; set; } = null!;
    }
}
