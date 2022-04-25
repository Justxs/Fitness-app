using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Database.Models
{
    public partial class PhysicalActivityRecord: ID
    {
        [Required]
        public DateTime? Time { get; set; }
        [Required]
        public double? Minutes { get; set; }
     

        [ForeignKey(nameof(ID_CaloriesRecord_PhysicalActivityRecord))]
        public virtual CaloriesRecord CaloriesRecordObj { get; set; } = null!;
        public int ID_CaloriesRecord_PhysicalActivityRecord { get; set; }

        [ForeignKey(nameof(ID_PhysicalActivity_PhysicalActivityRecord))]
        public virtual PhysicalActivity PhysicalActivityObj { get; set; } = null!;
        public int ID_PhysicalActivity_PhysicalActivityRecord { get; set; }
    }
}
