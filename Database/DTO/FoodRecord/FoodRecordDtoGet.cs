using FitnessApp.Database.DTO.User;
using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Database.DTO
{
    public class FoodRecordDtoGet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public float Proteins { get; set; }
        public float Carbohydrates { get; set; }
        public float Fats { get; set; }
        public string? ImageUrl { get; set; }
        public UserDtoGet User { get; set; }
        public DateTime Date { get; set; }
    }
}
