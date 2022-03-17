using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class PhysicalActivityRecord
    {
        public DateTime? Time { get; set; }
        public double? Minutes { get; set; }
        public int IdPhysicalActivityRecord { get; set; }
        public int FkCaloriesRecordidCaloriesRecord { get; set; }
        public int FkPhysicalActivityidPhysicalActivity { get; set; }

        public virtual CaloriesRecord FkCaloriesRecordidCaloriesRecordNavigation { get; set; } = null!;
        public virtual PhysicalActivity FkPhysicalActivityidPhysicalActivityNavigation { get; set; } = null!;
    }
}
