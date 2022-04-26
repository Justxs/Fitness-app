using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Database.Models
{
    public partial class CanHave: ID
    {
        public int ID_UserData { get; set; }

        [ForeignKey(nameof(ID_FoodAllergy_CanHAve))]
        public virtual FoodAllergy FoodAllergyObj { get; set; } = null!;
        public int ID_FoodAllergy_CanHAve { get; set; }
    }
}
