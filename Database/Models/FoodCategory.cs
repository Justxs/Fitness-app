using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class FoodCategory
    {
        public FoodCategory()
        {
            ID_FoodCategoryNav_Inv = new HashSet<FoodCategory>();
            NotPrefers = new HashSet<NotPrefer>();
            Prefers = new HashSet<Prefer>();
        }

        public string? Name { get; set; }
        public int ID { get; set; }
        public int? ID_FoodCategory { get; set; }

        public virtual FoodCategory? ID_FoodCategoryNav { get; set; }
        public virtual ICollection<FoodCategory> ID_FoodCategoryNav_Inv { get; set; }
        public virtual ICollection<NotPrefer> NotPrefers { get; set; }
        public virtual ICollection<Prefer> Prefers { get; set; }
    }
}
