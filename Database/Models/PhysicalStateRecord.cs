using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Database.Models
{
    public partial class PhysicalStateRecord: ID
    {
        [Required]
        public DateTime? Date { get; set; }
        [Required]
        public double? Weight { get; set; }
        [Required]
        public double? Height { get; set; }

        [ForeignKey(nameof(ID_UserData_PhysicalStateRecord))]
        public virtual UserData UserDataObj { get; set; } = null!;
        public int ID_UserData_PhysicalStateRecord { get; set; }
    }
}
