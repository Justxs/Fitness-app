using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Database.DTO
{
    public class FoodRecordDtoForm
    {
        [Required]
        [MaxLength(128)]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Required]
        [Range(0,int.MaxValue)]
        public float Calories { get; set; }
        [Required]
        [Range(0,int.MaxValue)]
        public float Proteins { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public float Carbohydrates { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public float Fats{ get; set; }
        [DataType(DataType.Url)]
        public string? ImageUrl { get; set; }
    }
}
