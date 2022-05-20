using AutoMapper;
using FitnessApp.Database.DTO;
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
            List<FoodRecord> products = await _context.FoodRecords.ToListAsync();
            List<FoodRecordDtoGet> result = _mapper.Map<List<FoodRecordDtoGet>>(products);
            return result;
        }
        public async Task<FoodRecordDtoGet> GetFoodRecordAsync(int id)
        {
            FoodRecord products = await _context.FoodRecords.FirstOrDefaultAsync(x=>x.Id == id);
            FoodRecordDtoGet result = _mapper.Map<FoodRecordDtoGet>(products);
            return result;
        }
        public async Task<List<FoodRecordDtoGet>> GetUserFoodRecordsAsync(int userId)
        {
            List<FoodRecord> products = await _context.FoodRecords.Where(x => x.UserId == userId).Include(x=>x.User).ToListAsync();
            List<FoodRecordDtoGet> result = _mapper.Map<List<FoodRecordDtoGet>>(products);
            return result;
        }
        public async Task<FoodRecordDtoGet> GetUserFoodRecordAsync(int userId, int id)
        {
            FoodRecord products = await _context.FoodRecords.Where(x => x.UserId == userId).Include(x => x.User).FirstOrDefaultAsync(x => x.Id == id);
            FoodRecordDtoGet result = _mapper.Map<FoodRecordDtoGet>(products);
            return result;
        }
        public async Task<FoodRecordDtoGet> AddFoodRecordAsync(FoodRecordDtoForm productForm, int userId)
        {
            FoodRecord product = _mapper.Map<FoodRecord>(productForm);
            product.UserId = userId;
            product.User = await _context.Users.FirstOrDefaultAsync(x => x.Id == userId);
            product =  (await _context.FoodRecords.AddAsync(product)).Entity;
            await _context.SaveChangesAsync();

            FoodRecordDtoGet result = _mapper.Map<FoodRecordDtoGet>(product);
            return result;
        }
        public async Task<FoodRecordDtoGet> UpdateFoodRecordAsync(FoodRecordDtoForm productForm, int id, int userId)
        {
            FoodRecord oldProduct = await _context.FoodRecords.FirstOrDefaultAsync(x=>x.Id==id && x.UserId == userId);
            FoodRecord product = _mapper.Map<FoodRecord>(productForm);
            product.Id = id;
            product.UserId = oldProduct.UserId;
            product.User = oldProduct.User;
            _context.Entry(oldProduct).State = EntityState.Detached;
            product = (_context.FoodRecords.Update(product)).Entity;
            await _context.SaveChangesAsync();
            _context.Entry(product).State = EntityState.Modified;

            FoodRecordDtoGet result = _mapper.Map<FoodRecordDtoGet>(product);
            return result;
        }

        public async Task<FoodRecordDtoGet> RemoveFoodRecordAsync(int id, int userId)
        {
            FoodRecord product = await _context.FoodRecords.FirstOrDefaultAsync(x=>x.Id==id && x.UserId == userId);
            _context.Entry(product).State = EntityState.Detached;
            _context.FoodRecords.Remove(product);
            await _context.SaveChangesAsync();
            _context.Entry(product).State = EntityState.Deleted;

            FoodRecordDtoGet result = _mapper.Map<FoodRecordDtoGet>(product);
            return result;
        }

        public bool Exists(int id)
        {
            return _context.FoodRecords.Any(x=>x.Id==id);
        }
    }
}
