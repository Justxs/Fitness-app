using AutoMapper;
using FitnessApp.Database.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Handlers
{
    public class RolesHandler
    {
        private readonly RoleManager<Role> _roleManager;

        public RolesHandler(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }
        [HttpPost("add")]
        public async Task<IdentityResult> Add(string name)
        {
            var result = await _roleManager.CreateAsync(new Role(name));
            return result;
        }
        public async Task<Role> GetByName(string name)
        {
            Role role = await _roleManager.FindByNameAsync(name);
            return role;
        }
        public async Task<Role> GetByid(string id)
        {
            Role role = await _roleManager.FindByIdAsync(id);
            return role;
        }
        public async Task<IdentityResult> RemoveByName(string name)
        {
            var role = await GetByName(name);
            var result = await _roleManager.DeleteAsync(role);
            return result;
        }
        public async Task<IdentityResult> RemoveById(string id)
        {
            var role = await GetByid(id);
            var result = await _roleManager.DeleteAsync(role);
            return result;
        }

        public IQueryable<Role> GetAll()
        {
            var roles =  _roleManager.Roles;
            return roles;
        }
    }
}
