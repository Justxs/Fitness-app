using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class UserData
    {
        public UserData()
        {
            CaloriesRecords = new HashSet<CaloriesRecord>();
            PhysicalStateRecords = new HashSet<PhysicalStateRecord>();
            WeightLossGoals = new HashSet<WeightLossGoal>();
        }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int ID { get; set; }

        public virtual ICollection<CaloriesRecord> CaloriesRecords { get; set; }
        public virtual ICollection<PhysicalStateRecord> PhysicalStateRecords { get; set; }
        public virtual ICollection<WeightLossGoal> WeightLossGoals { get; set; }
    }
}
