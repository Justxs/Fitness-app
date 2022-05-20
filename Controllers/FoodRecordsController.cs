using AutoMapper;
using FitnessApp.Database.DTO;
using FitnessApp.Database.DTO.FoodRecord;
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
    public class FoodRecordsController : Controller
    {
        private readonly FoodRecordsHandler _handler;
        public FoodRecordsController(IMapper mapper, FitnessAppDbContext context)
        {
            _handler = new FoodRecordsHandler(context,mapper);
        }
        [Authorize(Roles = "admin")]
        [HttpGet("admin")]
        public async Task<IActionResult> GetAllFoodRecords()
        {
            List<FoodRecordDtoGet> result = await _handler.GetAllFoodRecordsAsync();
            return Ok(result);
        }
        [HttpGet("admin/{id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> GetFoodRecord(int id)
        {
            FoodRecordDtoGet result = await _handler.GetFoodRecordAsync(id);
           return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetUserFoodRecords()
        {
            int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            List<FoodRecordDtoGet> result = await _handler.GetUserFoodRecordsAsync(userId);
            return Ok(result);
        }

        [HttpGet("daily")]
        public async Task<IActionResult> GetUserDailyStatistics()
        {
            int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            DateTime now = DateTime.Now;
            DateTime start = new DateTime(now.Year, now.Month, now.Day);
            DateTime end = start.AddDays(1);
            FoodRecordDtoAggregate result = await _handler.GetFoodStatisticsByTimeInterval(start, end, userId);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserFoodRecord(int id)
        {
            int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            FoodRecordDtoGet result = await _handler.GetUserFoodRecordAsync(userId,id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddFoodRecord([FromBody] FoodRecordDtoForm FoodRecordDto)
        {
            int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            FoodRecordDtoGet result = await _handler.AddFoodRecordAsync(FoodRecordDto,userId);
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFoodRecord([FromBody] FoodRecordDtoForm FoodRecordDto, int id)
        {
            int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            if (!_handler.Exists(id))
            {
                return NotFound();
            }
            FoodRecordDtoGet result = await _handler.UpdateFoodRecordAsync(FoodRecordDto, id,userId);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveFoodRecord(int id)
        {
            if (!_handler.Exists(id))
            {
                return NotFound();
            }
            int userId = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
            FoodRecordDtoGet result = await _handler.RemoveFoodRecordAsync(id,userId);
            return Ok(result);
        }
    }
}
