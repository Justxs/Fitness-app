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

        public int ID { get; set; }
        public int ID_WeightLossGoal { get; set; }

        public virtual WeightLossGoal ID_WeightLossGoalNav { get; set; } = null!;
        public virtual ICollection<EatingActivityRecord> EatingActivityRecords { get; set; }
    }
}
