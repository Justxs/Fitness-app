using AutoMapper;
using FitnessApp.Database.DTO;
using FitnessApp.Database.DTO.FoodRecord;
using FitnessApp.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp.Handlers
{
    public class FoodRecordsHandler
    {
        private readonly FitnessAppDbContext _context;
        private readonly IMapper _mapper;
        public FoodRecordsHandler(FitnessAppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<FoodRecordDtoGet>> GetAllFoodRecordsAsync()
        {
            List<FoodRecord> records = await _context.FoodRecords.Include(x=>x.User).ToListAsync();
            List<FoodRecordDtoGet> result = _mapper.Map<List<FoodRecordDtoGet>>(records);
            return result;
        }
        public async Task<FoodRecordDtoGet> GetFoodRecordAsync(int id)
        {
            FoodRecord records = await _context.FoodRecords.Include(x => x.User).FirstOrDefaultAsync(x=>x.Id == id);
            FoodRecordDtoGet result = _mapper.Map<FoodRecordDtoGet>(records);
            return result;
        }
        public async Task<FoodRecordDtoAggregate> GetFoodStatisticsByTimeInterval(DateTime start, DateTime end, int userId)
        {
            List<FoodRecord> records = await _context.FoodRecords.Include(x => x.User).Where(x => x.UserId == userId && x.Date >= start && x.Date < end).ToListAsync();
            if(records.Count == 0)
            {
                return null;
            }
            FoodRecordDtoAggregate result = _mapper.Map<List<FoodRecord>, FoodRecordDtoAggregate>(records);
            return result;
        }
        public async Task<List<FoodRecordDtoGet>> GetUserFoodRecordsAsync(int userId)
        {
            List<FoodRecord> records = await _context.FoodRecords.Include(x => x.User).Where(x => x.UserId == userId).ToListAsync();
            List<FoodRecordDtoGet> result = _mapper.Map<List<FoodRecordDtoGet>>(records);
            return result;
        }
        public async Task<FoodRecordDtoGet> GetUserFoodRecordAsync(int userId, int id)
        {
            FoodRecord records = await _context.FoodRecords.Where(x => x.UserId == userId).Include(x => x.User).FirstOrDefaultAsync(x => x.Id == id);
            FoodRecordDtoGet result = _mapper.Map<FoodRecordDtoGet>(records);
            return result;
        }
        public async Task<FoodRecordDtoGet> AddFoodRecordAsync(FoodRecordDtoForm recordForm, int userId)
        {
            FoodRecord record = _mapper.Map<FoodRecord>(recordForm);
            record.UserId = userId;
            record.User = await _context.Users.FirstOrDefaultAsync(x => x.Id == userId);
            record.Date = DateTime.Now;
            record =  (await _context.FoodRecords.AddAsync(record)).Entity;
            await _context.SaveChangesAsync();

            FoodRecordDtoGet result = _mapper.Map<FoodRecordDtoGet>(record);
            return result;
        }
        public async Task<FoodRecordDtoGet> UpdateFoodRecordAsync(FoodRecordDtoForm recordForm, int id, int userId)
        {
            FoodRecord oldrecord = await _context.FoodRecords.FirstOrDefaultAsync(x=>x.Id==id && x.UserId == userId);
            FoodRecord record = _mapper.Map<FoodRecord>(recordForm);
            record.Id = id;
            record.UserId = oldrecord.UserId;
            record.User = oldrecord.User;
            _context.Entry(oldrecord).State = EntityState.Detached;
            record = (_context.FoodRecords.Update(record)).Entity;
            await _context.SaveChangesAsync();
            _context.Entry(record).State = EntityState.Modified;

            FoodRecordDtoGet result = _mapper.Map<FoodRecordDtoGet>(record);
            return result;
        }

        public async Task<FoodRecordDtoGet> RemoveFoodRecordAsync(int id, int userId)
        {
            FoodRecord record = await _context.FoodRecords.FirstOrDefaultAsync(x=>x.Id==id && x.UserId == userId);
            _context.Entry(record).State = EntityState.Detached;
            _context.FoodRecords.Remove(record);
            await _context.SaveChangesAsync();
            _context.Entry(record).State = EntityState.Deleted;

            FoodRecordDtoGet result = _mapper.Map<FoodRecordDtoGet>(record);
            return result;
        }

        public bool Exists(int id)
        {
            return _context.FoodRecords.Any(x=>x.Id==id);
        }
    }
}
