using AutoMapper;
using FitnessApp.Database;
using FitnessApp.Database.DTO;
using FitnessApp.Database.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FoodProductsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly DatabaseUtils<FoodProduct> _dbUtils;
        public FoodProductsController(IMapper mapper, FitnessAppDbContext context)
        {
            _mapper = mapper;
            _dbUtils = new DatabaseUtils<FoodProduct>(context);
        }
        [HttpGet("Get")]
        public async Task<IActionResult> GetFoodProduct([FromQuery] int id)
        {
            try
            {
                FoodProduct FoodProduct = _dbUtils.GetElement((dbSet) => dbSet.FirstOrDefault(x => x.Id == id));
                FoodProductDtoGet result = _mapper.Map<FoodProductDtoGet>(FoodProduct);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("Add")]
        public async Task<IActionResult> AddFoodProduct([FromBody] FoodProductDtoCreate FoodProductDto)
        {
            try
            {
                FoodProduct spot = _mapper.Map<FoodProduct>(FoodProductDto);
                spot = _dbUtils.AddElement(spot);
                FoodProductDtoGet result = _mapper.Map<FoodProductDtoGet>(spot);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("Update")]
        public async Task<IActionResult> UpdateFoodProduct([FromBody] FoodProductDtoUpdate FoodProductDto, [FromQuery] int id)
        {
            try
            {
                FoodProduct spot = _mapper.Map<FoodProduct>(FoodProductDto);
                spot = _dbUtils.UpdateElement(id, spot);
                FoodProductDtoGet result = _mapper.Map<FoodProductDtoGet>(spot);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("Remove")]
        public async Task<IActionResult> RemoveFoodProduct([FromQuery] int id)
        {
            try
            {
                FoodProduct spot = _dbUtils.DeleteElement(id);
                return Ok(spot);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
