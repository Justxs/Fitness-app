using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class ContainsProd
    {
        public int ID_FoodProduct { get; set; }
        public int ID_FoodCategory { get; set; }

        public virtual FoodProduct ID_FoodProductNav { get; set; } = null!;
    }
}
