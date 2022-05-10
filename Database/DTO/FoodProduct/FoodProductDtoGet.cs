using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Database.DTO
{
    public class FoodProductDtoGet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories100g { get; set; }
        public float Proteins100g { get; set; }
        public float Carbohydrates100g { get; set; }
        public float Fats100g { get; set; }
        public string? ImageUrl { get; set; }
    }
}
