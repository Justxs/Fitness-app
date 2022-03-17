using System;
using System.Collections.Generic;

namespace FitnessApp.Database.Models
{
    public partial class PhysicalStateRecord
    {
        public DateTime? Date { get; set; }
        public double? Weight { get; set; }
        public double? Height { get; set; }
        public int IdPhysicalStateRecord { get; set; }
        public int FkUserdataidUserdata { get; set; }

        public virtual Userdatum FkUserdataidUserdataNavigation { get; set; } = null!;
    }
}
