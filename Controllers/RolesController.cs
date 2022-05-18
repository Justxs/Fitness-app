using FitnessApp.Handlers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "admin")]
    public class RolesController : ControllerBase
    {
        private readonly RolesHandler _rolesService;
        public RolesController(RolesHandler rolesService)
        {
            _rolesService = rolesService;
        }
        [HttpPost("add")]
        public async Task<ActionResult> AddRole(string name)
        {
            var result = await _rolesService.Add(name);
            return Ok(result);
        }
        [HttpGet("getByName")]
        public async Task<ActionResult> GetRoleByName(string name)
        {
            var result = await _rolesService.GetByName(name);
            return Ok(result);
        }
        [HttpGet("getById")]
        public async Task<ActionResult> GetRoleByID(string id)
        {
            var result = await _rolesService.GetByid(id);
            return Ok(result);
        }
        [HttpDelete("removeByName")]
        public async Task<ActionResult> RemoveRoleByName(string name)
        {
            var result = await _rolesService.RemoveByName(name);
            return Ok(result);
        }
        [HttpDelete("removeById")]
        public async Task<ActionResult> RemoveRoleById(string id)
        {
            var result = await _rolesService.RemoveById(id);

            return Ok(result);
        }
        [HttpGet("getAll")]
        public ActionResult GetAll()
        {
            var roles = _rolesService.GetAll();

            return Ok(roles);
        }
    }
}
