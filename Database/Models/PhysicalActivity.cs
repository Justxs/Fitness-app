using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Database.Models
{
    public partial class PhysicalActivity: ID
    {
        public PhysicalActivity()
        {
            PhysicalActivityRecords = new HashSet<PhysicalActivityRecord>();
        }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int? Calories1min { get; set; }

        public virtual ICollection<PhysicalActivityRecord> PhysicalActivityRecords { get; set; }
    }
}
