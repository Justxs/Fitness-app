using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class CanHave
    {
        public int ID_FoodAllergy { get; set; }
        public int ID_UserData { get; set; }

        public virtual FoodAllergy ID_FoodAllergyNav { get; set; } = null!;
    }
}
