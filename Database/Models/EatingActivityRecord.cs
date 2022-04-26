using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Database.Models
{
    public partial class EatingActivityRecord: ID
    {
        [Required]
        public int Grams { get; set; }

        [ForeignKey(nameof(ID_CaloriesRecord_EatingActivityRecord))]
        public virtual CaloriesRecord? CaloriesRecordObj { get; set; } = null!;
        public int? ID_CaloriesRecord_EatingActivityRecord { get; set; }


        [ForeignKey(nameof(ID_FoodProduct_EatingActivityRecord))]
        public virtual FoodProduct? FoodProductObj { get; set; } = null!;
        public int? ID_FoodProduct_EatingActivityRecord { get; set; }
    }
}
