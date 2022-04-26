using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Database.Models
{
    public partial class Diet: ID
    {
        public Diet()
        {
            EatingActivityRecords = new HashSet<EatingActivityRecord>();
        }

        
        [ForeignKey(nameof(ID_WeightLossGoal_Diet))]
        public virtual WeightLossGoal WeightLossGoalObj { get; set; } = null!;
        public int ID_WeightLossGoal_Diet { get; set; }

        public virtual ICollection<EatingActivityRecord> EatingActivityRecords { get; set; }
    }
}
