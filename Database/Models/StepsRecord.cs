using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class StepsRecord
    {
        public DateTime? Date { get; set; }
        public int? Steps { get; set; }
        public int IdStepsRecord { get; set; }
        public int FkCaloriesRecordidCaloriesRecord { get; set; }

        public virtual CaloriesRecord FkCaloriesRecordidCaloriesRecordNavigation { get; set; } = null!;
    }
}
