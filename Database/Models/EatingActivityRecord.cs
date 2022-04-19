using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class EatingActivityRecord
    {
        public int? Grams { get; set; }
        public int ID { get; set; }
        public int ID_CaloriesRecord { get; set; }
        public int ID_FoodProduct { get; set; }
        public int ID_Diet { get; set; }

        public virtual CaloriesRecord ID_CaloriesRecordNav { get; set; } = null!;
        public virtual Diet ID_DietNav { get; set; } = null!;
        public virtual FoodProduct ID_FoodProductNav { get; set; } = null!;
    }
}
