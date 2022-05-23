using FitnessApp.Database.DTO.User;

namespace FitnessApp.Database.DTO.FoodRecord
{
    public class FoodRecordDtoAggregate
    {
        public FoodRecordDtoAggregate()
        {

        }
        public FoodRecordDtoAggregate(float calories, float proteins, float carbohydrates, float fats, UserDtoGet user)
        {
            Calories = calories;
            Proteins = proteins;
            Carbohydrates = carbohydrates;
            Fats = fats;
            User = user;
        }

        public float Calories { get; set; }
        public float Proteins { get; set; }
        public float Carbohydrates { get; set; }
        public float Fats { get; set; }
        public UserDtoGet User { get; set; }
    }
}
