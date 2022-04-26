using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessApp.Database.Models
{
    public partial class StepsRecord: ID
    {
        [Required]
        public DateTime? Date { get; set; }
        [Required]
        public int? Steps { get; set; }

        [ForeignKey(nameof(ID_CaloriesRecord_StepsRecord))]
        public virtual CaloriesRecord CaloriesRecordObj { get; set; } = null!;
        public int ID_CaloriesRecord_StepsRecord { get; set; }
    }
}
