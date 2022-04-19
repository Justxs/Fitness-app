using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class PhysicalActivityRecord
    {
        public DateTime? Time { get; set; }
        public double? Minutes { get; set; }
        public int ID { get; set; }
        public int ID_CaloriesRecord { get; set; }
        public int ID_PhysicalActivity { get; set; }

        public virtual CaloriesRecord ID_CaloriesRecordNav { get; set; } = null!;
        public virtual PhysicalActivity ID_PhysicalActivityNav { get; set; } = null!;
    }
}
