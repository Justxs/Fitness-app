using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class PhysicalActivity
    {
        public PhysicalActivity()
        {
            PhysicalActivityRecords = new HashSet<PhysicalActivityRecord>();
        }

        public string? Name { get; set; }
        public int? Calories1min { get; set; }
        public int IdPhysicalActivity { get; set; }

        public virtual ICollection<PhysicalActivityRecord> PhysicalActivityRecords { get; set; }
    }
}
