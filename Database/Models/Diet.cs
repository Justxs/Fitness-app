using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class Diet
    {
        public Diet()
        {
            EatingActivityRecords = new HashSet<EatingActivityRecord>();
        }

        public int IdDiet { get; set; }
        public int FkWeightLossGoalidWeightLossGoal { get; set; }

        public virtual WeightLossGoal FkWeightLossGoalidWeightLossGoalNavigation { get; set; } = null!;
        public virtual ICollection<EatingActivityRecord> EatingActivityRecords { get; set; }
    }
}
