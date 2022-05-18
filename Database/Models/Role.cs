using Microsoft.AspNetCore.Identity;

namespace FitnessApp.Database.Models
{
    public class Role: IdentityRole<int>
    {
        public Role(int id,string name): base(name)
        {
            this.Id = id;
            this.NormalizedName = name.ToUpper();
        }
        public Role(string name): base(name)
        {
            this.NormalizedName = name.ToUpper();
        }
    }
}
