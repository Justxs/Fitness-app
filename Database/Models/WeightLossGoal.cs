using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Database.Models
{
    public partial class WeightLossGoal: ID
    {
        public WeightLossGoal()
        {
            Diets = new HashSet<Diet>();
        }
        [Required]
        public DateTime? StartDate { get; set; }
        [Required]
        public double? StartWeight { get; set; }
        [Required]
        public DateTime? EndDate { get; set; }
        [Required]
        public double? EndWeight { get; set; }
        [Required]
        public int? Calories { get; set; }

        [ForeignKey(nameof(ID_UserData_WeightLossGoal))]
        public virtual UserData UserDataObj { get; set; } = null!;
        public int ID_UserData_WeightLossGoal { get; set; }

        public virtual ICollection<Diet> Diets { get; set; }
    }
}
