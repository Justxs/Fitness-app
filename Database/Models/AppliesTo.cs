using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Database.Models
{
    public partial class AppliesTo: ID
    {
        public int ID_FoodAllergy { get; set; }

        [ForeignKey(nameof(ID_FoodProduct_AppliesTo))]
        public virtual FoodProduct FoodProductObj { get; set; } = null!;
        public int ID_FoodProduct_AppliesTo { get; set; }
    }
}
