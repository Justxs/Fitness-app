using AutoMapper;
using FitnessApp.Database;
using FitnessApp.Database.DTO;
using FitnessApp.Database.Models;
using FitnessApp.Handlers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class FoodProductsController : Controller
    {
        private readonly FoodProductsHandler _handler;
        public FoodProductsController(IMapper mapper, FitnessAppDbContext context)
        {
            _handler = new FoodProductsHandler(context,mapper);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllFoodProducts()
        {
            List<FoodProductDtoGet> result = await _handler.GetAllFoodProductsAsync();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFoodProduct(int id)
        {
           FoodProductDtoGet result = await _handler.GetFoodProductAsync(id);
           return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> AddFoodProduct([FromBody] FoodProductDtoForm foodProductDto)
        {
            FoodProductDtoGet result = await _handler.AddFoodProductAsync(foodProductDto);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFoodProduct([FromBody] FoodProductDtoForm foodProductDto, int id)
        {
            if (!_handler.Exists(id))
            {
                return NotFound();
            }
            FoodProductDtoGet result = await _handler.UpdateFoodProductAsync(foodProductDto, id);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveFoodProduct(int id)
        {
            if (!_handler.Exists(id))
            {
                return NotFound();
            }
            FoodProductDtoGet result = await _handler.RemoveFoodProductAsync(id);
            return Ok(result);
        }
    }
}
