using System.ComponentModel.DataAnnotations;

namespace FitnessApp.Database.DTO
{
    public class UserDtoLogin
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberPassword { get; set; }

    }
}
