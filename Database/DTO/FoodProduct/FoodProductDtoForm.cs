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
        public float Proteins100g { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public float Carbohydrates100g { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public float Fats100g { get; set; }
        [DataType(DataType.Url)]
        public string? ImageUrl { get; set; }
    }
}
