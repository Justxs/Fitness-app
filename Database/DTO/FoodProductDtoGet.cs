using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Database.DTO
{
    public class FoodProductDtoGet
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(128)]
        public string Name { get; set; }
        [Required]
        public int Calories100g { get; set; }
        public string? ImageUrl { get; set; }
    }
}
