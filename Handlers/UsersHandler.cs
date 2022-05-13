using AutoMapper;
using FitnessApp.Database.DTO;
using FitnessApp.Database.Models;
using Microsoft.AspNetCore.Identity;
using System.Reflection;
using System.Security.Claims;

namespace FitnessApp.Handlers
{
    public class UsersHandler
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RolesHandler _rolesHandler;
        private readonly IMapper _mapper;

        public UsersHandler(RoleManager<Role> roleManager, UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _rolesHandler = new RolesHandler(roleManager);
        }

        public async Task<string> AddUser(UserDtoRegister data, string roleName)
        {
            var result = await _userManager.CreateAsync(_mapper.Map<User>(data), data.Password);

            if (result.Succeeded)
            {
                User user = await _userManager.FindByEmailAsync(data.Email);
                if (await _rolesHandler.GetByName(roleName) == null)
                {
                    await _userManager.DeleteAsync(user);
                    throw new Exception("Role name is invalid");
                }
                await _userManager.AddToRoleAsync(user, roleName);
                return result.ToString();

            }
            else
            {
                string errors = "";
                foreach (var error in result.Errors)
                {
                    errors += error.Code + error.Description + "\n";
                }
                throw new Exception(errors);
            }
        }

        public async Task<string> Login(UserDtoLogin data)
        {
            User user = await GetUser(data);

            var result = await _signInManager.PasswordSignInAsync(user, data.Password, data.RememberPassword, false);
            if(result.Succeeded)
                return user.UserName;
            throw new ArgumentException("Login credentials are incorrect");
        }
        private async Task<User> GetUser(UserDtoLogin data)
        {
            User user;
            if (isEmail(data.Username))
            {
                user = await GetUserByUsername(data.Username);
            }
            else
            {
                user = await GetUserByEmail(data.Username);
            }
            return user;
        }
        private bool isEmail(string email)
        {
            try
            {
                var em = new System.Net.Mail.MailAddress(email);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool IsLoggedIn(ClaimsPrincipal claims)
        {
            return claims.Identity.IsAuthenticated;
        }
        public async Task<bool> Logout()
        {
            await _signInManager.SignOutAsync();
            return true;
        }

        public async Task<IdentityResult> RemoveUserById(string id)
        {
            User user = await GetUserById(id);
            var result = await _userManager.DeleteAsync(user);
            return result;
        }

        public async Task<IdentityResult> RemoveUserByUsername(string username)
        {
            User user = await GetUserByUsername(username);
            var result = await _userManager.DeleteAsync(user);
            return result;
        }

        public async Task<IdentityResult> UpdateUserData(UserDtoUpdate data, string userId)//Fix this
        {
            User original = await GetUserById(userId);
            User user = _mapper.Map<User>(data);

            PropertyInfo[] properties = typeof(User).GetProperties().Where(prop => prop.Name != "Id").ToArray();
            foreach (PropertyInfo property in properties)
            {

                var value = property.GetValue(user);
                if (value != null)
                {
                    property.SetValue(original, value);
                }
            }
            var result = await _userManager.UpdateAsync(original);
            return result;
        }

        public async Task<List<User>> GetAll(string? role)
        {
            if (role == null)
                return _userManager.Users.Select(x=>x).ToList();
            else
            return (await _userManager.GetUsersInRoleAsync(role)).ToList();
            
        }

        public async Task<User> GetUserByUsername(string username)
        {
            User user = await _userManager.FindByNameAsync(username);
            return user;
        }

        public async Task<User> GetUserByEmail(string email)
        {
            User user = await _userManager.FindByEmailAsync(email);
            return user;
        }

        public async Task<User> GetUserById(string id)
        {
            User user = await _userManager.FindByIdAsync(id);
            return user;
        }
    }
}
