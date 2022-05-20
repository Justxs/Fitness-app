using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Database.Models
{
    public partial class FoodRecord: ID
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public float Proteins { get; set; }

        [Required]
        public float Carbohydrates { get; set; }

        [Required]
        public float Fats { get; set; }
        [Required]
        public float Calories { get; set; }
        public string? ImageUrl { get; set; }
        [ForeignKey((nameof(UserId)))]
        public User User { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }

    }
}
