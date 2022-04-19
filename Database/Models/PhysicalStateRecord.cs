using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class PhysicalStateRecord
    {
        public DateTime? Date { get; set; }
        public double? Weight { get; set; }
        public double? Height { get; set; }
        public int ID { get; set; }
        public int ID_UserData { get; set; }

        public virtual UserData ID_UserDataNav { get; set; } = null!;
    }
}
