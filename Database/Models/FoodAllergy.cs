using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Database.Models
{
    public partial class FoodAllergy: ID
    {
        public FoodAllergy()
        {
            CanHaves = new HashSet<CanHave>();
        }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<CanHave> CanHaves { get; set; }
    }
}
