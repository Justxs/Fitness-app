using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Database.Models
{
    public partial class Prefer: ID
    {
        public int ID_UserData { get; set; }

        [ForeignKey(nameof(ID_FoodCategory_Prefer))]
        public virtual FoodCategory FoodCategoryObj { get; set; } = null!;
        public int ID_FoodCategory_Prefer { get; set; }
    }
}
