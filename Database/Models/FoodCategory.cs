using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Database.Models
{
    public partial class FoodCategory: ID
    {
        public FoodCategory()
        {
            ID_FoodCategoryNav_Inv = new HashSet<FoodCategory>();
            NotPrefers = new HashSet<NotPrefer>();
            Prefers = new HashSet<Prefer>();
        }
        [Required]
        public string Name { get; set; }

        [ForeignKey(nameof(ID_FoodCategory_FoodCategory))]
        public virtual FoodCategory? FoodCategoryObj { get; set; }
        public int? ID_FoodCategory_FoodCategory { get; set; }

        public virtual ICollection<FoodCategory> ID_FoodCategoryNav_Inv { get; set; }
        public virtual ICollection<NotPrefer> NotPrefers { get; set; }
        public virtual ICollection<Prefer> Prefers { get; set; }
    }
}
