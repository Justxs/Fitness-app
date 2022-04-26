using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Database.Models
{
    public partial class UserData: ID
    {
        public UserData()
        {
            CaloriesRecords = new HashSet<CaloriesRecord>();
            PhysicalStateRecords = new HashSet<PhysicalStateRecord>();
            WeightLossGoals = new HashSet<WeightLossGoal>();
        }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }

        public virtual ICollection<CaloriesRecord> CaloriesRecords { get; set; }
        public virtual ICollection<PhysicalStateRecord> PhysicalStateRecords { get; set; }
        public virtual ICollection<WeightLossGoal> WeightLossGoals { get; set; }
    }
}
