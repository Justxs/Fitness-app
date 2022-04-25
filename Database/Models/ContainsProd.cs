using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Database.Models
{
    public partial class ContainsProd: ID
    {
        public int ID_FoodCategory { get; set; }

        [ForeignKey(nameof(ID_FoodProduct_ContainsProd))]
        public virtual FoodProduct FoodProductObj { get; set; } = null!;
        public int ID_FoodProduct_ContainsProd { get; set; }
    }
}
