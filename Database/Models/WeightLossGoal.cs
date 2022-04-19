using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class WeightLossGoal
    {
        public WeightLossGoal()
        {
            Diets = new HashSet<Diet>();
        }

        public DateTime? StartDate { get; set; }
        public double? StartWeight { get; set; }
        public DateTime? EndDate { get; set; }
        public double? EndWeight { get; set; }
        public int? Calories { get; set; }
        public int ID { get; set; }
        public int ID_UserData { get; set; }

        public virtual UserData ID_UserDataNav { get; set; } = null!;
        public virtual ICollection<Diet> Diets { get; set; }
    }
}
