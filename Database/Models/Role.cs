using Microsoft.AspNetCore.Identity;

namespace FitnessApp.Database.Models
{
    public class Role: IdentityRole<int>
    {
        public Role()
        {

        }
        public Role(string name): base(name)
        {

        }
    }
}
