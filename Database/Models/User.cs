using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessApp.Database.Models
{
    public class User: IdentityUser<int>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool RememberPassword { get; set; }

    }
}
