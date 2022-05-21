//TO DO:
//Lockouts
//Email confirmation
//Phone number confirmation
//2FA
//Login with google, etc.
using FitnessApp.Database.DTO;
using FitnessApp.Database.DTO.User;
using FitnessApp.Database.Models;
using FitnessApp.Handlers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FitnessApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly UsersHandler _usersHandler;
        public UsersController(UsersHandler usersHandler)
        {
            _usersHandler = usersHandler;
        }
        [HttpPost("addUser")]
        [AllowAnonymous]
        public async Task<ActionResult> AddRegularUser([FromBody] UserDtoRegister registerModel)
        {
            string result;
            try
            {
                result = await _usersHandler.AddUser(registerModel,"user");
                return Ok(result);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return BadRequest(result);
            }
        }
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] UserDtoLogin loginCredentials)
        {
            string result;
            try
            {
                result = await _usersHandler.Login(loginCredentials);
                return Ok(result);
            }
            catch(ArgumentException ex)
            {
                result=ex.Message;
                return BadRequest(result);
            }
            
        }
        [AllowAnonymous]
        [HttpPost("isLoggedIn")]
        public ActionResult isLoggedIn()
        {
            bool result = _usersHandler.IsLoggedIn(User);
            if (result)
            {
                return Ok(User.Identity.Name);
            }
            else
            {
                return Ok(false);
            }
        }
        [HttpPost("logout")]
        public async Task<ActionResult> Logout()
        {
            var result = await _usersHandler.Logout();
            return Ok(result);
        }
        [Authorize(Roles = "admin")]
        [HttpGet("admin/getAll")]
        public async Task<ActionResult> GetAllUsers(string? roleName)
        {
            List<User> users = await _usersHandler.GetAll(roleName);
            return Ok(users);
        }
        [Authorize(Roles = "admin")]
        [HttpPost("admin/addUser")]
        public async Task<ActionResult> AddUser([FromBody] UserDtoRegister registerModel,string roleName)
        {
            string result;
            try
            {
                result = await _usersHandler.AddUser(registerModel, roleName);
                return Ok(result);
            }
            catch (Exception ex)
            {
                result = ex.Message;
                return BadRequest(result);
            }
        }
        [HttpPut("update")]
        public async Task<ActionResult> Update([FromBody] UserDtoUpdate updateModel)
        {
            string userID = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            string result;
            try
            {
                result = (await _usersHandler.UpdateUserData(updateModel, userID)).ToString();
                return Ok(result);
            }catch (Exception ex)
            {
                result = ex.Message;
                return BadRequest(result);
            }
        }
    }
}
