using FitnessApp.Database.DTO.User;

namespace FitnessApp.Database.DTO.FoodRecord
{
    public class FoodRecordDtoAggregate
    {
        public int Calories { get; set; }
        public float Proteins { get; set; }
        public float Carbohydrates { get; set; }
        public float Fats { get; set; }
        public UserDtoGet User { get; set; }
    }
}
