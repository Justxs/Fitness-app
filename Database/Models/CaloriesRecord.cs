using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class CaloriesRecord
    {
        public DateTime? Date { get; set; }
        public double? ChangeInCalories { get; set; }
        public int ID { get; set; }
        public int ID_UserData { get; set; }

        public virtual UserData ID_UserDataNav { get; set; } = null!;
        public virtual EatingActivityRecord EatingActivityRecord { get; set; } = null!;
        public virtual PhysicalActivityRecord PhysicalActivityRecord { get; set; } = null!;
        public virtual StepsRecord StepsRecord { get; set; } = null!;
    }
}
