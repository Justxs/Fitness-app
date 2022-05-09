using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Database.DTO
{
    public class FoodProductDtoForm
    {
        [Required]
        [MaxLength(128)]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Required]
        [Range(0,int.MaxValue)]
        public int Calories100g { get; set; }
        public string? ImageUrl { get; set; }
    }
}
