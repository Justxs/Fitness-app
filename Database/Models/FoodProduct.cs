using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class FoodProduct
    {
        public FoodProduct()
        {
            AppliesTos = new HashSet<AppliesTo>();
            ContainsProds = new HashSet<ContainsProd>();
            EatingActivityRecords = new HashSet<EatingActivityRecord>();
        }

        public string? Name { get; set; }
        public int? Calories100g { get; set; }
        public string? ImageUrl { get; set; }
        public int ID { get; set; }

        public virtual ICollection<AppliesTo> AppliesTos { get; set; }
        public virtual ICollection<ContainsProd> ContainsProds { get; set; }
        public virtual ICollection<EatingActivityRecord> EatingActivityRecords { get; set; }
    }
}
