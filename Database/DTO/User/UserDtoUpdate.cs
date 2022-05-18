
namespace FitnessApp.Database.DTO
{
    public class UserDtoUpdate
    {
        
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public string? RepeatPassword { get; set; }
        public bool? RememberPassword { get; set; }
    }
}
