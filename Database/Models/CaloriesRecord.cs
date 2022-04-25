using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Database.Models
{
    public partial class CaloriesRecord: ID
    {
        public DateTime? Date { get; set; }
        public double? ChangeInCalories { get; set; }
        
        [ForeignKey(nameof(ID_UserData_CaloriesRecord))]
        public virtual UserData UserDataObj { get; set; } = null!;
        public int ID_UserData_CaloriesRecord { get; set; }

        public virtual EatingActivityRecord EatingActivityRecord { get; set; } = null!;
        public virtual PhysicalActivityRecord PhysicalActivityRecord { get; set; } = null!;
        public virtual StepsRecord StepsRecord { get; set; } = null!;
    }
}
