using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class FoodAllergy
    {
        public FoodAllergy()
        {
            CanHaves = new HashSet<CanHave>();
        }

        public string? Name { get; set; }
        public int IdFoodAllergy { get; set; }

        public virtual ICollection<CanHave> CanHaves { get; set; }
    }
}
