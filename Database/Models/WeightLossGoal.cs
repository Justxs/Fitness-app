using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Database.Models
{
    public partial class WeightLossGoal: ID
    {
        [Required]
        public DateTime? StartDate { get; set; }
        [Required]
        public double? StartWeight { get; set; }
        [Required]
        public DateTime? EndDate { get; set; }
        [Required]
        public double? EndWeight { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; } = null!;
        public int UserId { get; set; }
    }
}
