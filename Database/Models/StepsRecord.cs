using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class StepsRecord
    {
        public DateTime? Date { get; set; }
        public int? Steps { get; set; }
        public int ID { get; set; }
        public int ID_CaloriesRecord { get; set; }

        public virtual CaloriesRecord ID_CaloriesRecordNav { get; set; } = null!;
    }
}
