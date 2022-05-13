using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessApp.Database.Models
{
    public class User: IdentityUser<int>
    {
        public User(): base()
        {

        }

        public User(int id,string firstName, string lastName, bool rememberPassword, string userName, string email, bool emailConfirmed, string passwordHash, string securityStamp, string concurrencyStamp, string? phoneNumber = null, bool phoneNumberConfirmed = false, bool twoFactorEnabled = false, DateTime? lockoutEnd = null, bool lockoutEnabled = true): base()
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.RememberPassword = rememberPassword;
            this.UserName = userName;
            this.NormalizedUserName = userName.ToUpper();
            this.Email = email;
            this.NormalizedEmail = email.ToUpper();
            this.EmailConfirmed = emailConfirmed;
            this.PasswordHash = passwordHash;
            this.SecurityStamp = securityStamp;
            this.ConcurrencyStamp = concurrencyStamp;
            this.PhoneNumber = phoneNumber;
            this.PhoneNumberConfirmed = phoneNumberConfirmed;
            this.TwoFactorEnabled = twoFactorEnabled;
            this.LockoutEnd = lockoutEnd;
            this.LockoutEnabled = lockoutEnabled;
        }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool RememberPassword { get; set; }

    }
}
