using AutoMapper;
using FitnessApp.Database.DTO;
using FitnessApp.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessApp.Handlers
{
    public class FoodProductsHandler
    {
        private readonly FitnessAppDbContext _context;
        private readonly IMapper _mapper;
        public FoodProductsHandler(FitnessAppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<FoodProductDtoGet>> GetAllFoodProductsAsync()
        {
            List<FoodProduct> products = await _context.FoodProducts.ToListAsync();
            List<FoodProductDtoGet> result = _mapper.Map<List<FoodProductDtoGet>>(products);
            return result;
        }
        public async Task<FoodProductDtoGet> GetFoodProductAsync(int id)
        {
            FoodProduct products = await _context.FoodProducts.FirstOrDefaultAsync(x=>x.Id == id);
            FoodProductDtoGet result = _mapper.Map<FoodProductDtoGet>(products);
            return result;
        }
        public async Task<FoodProductDtoGet> AddFoodProductAsync(FoodProductDtoForm productForm)
        {
            FoodProduct product = _mapper.Map<FoodProduct>(productForm);
            product.Calories100g = 4 * product.Proteins100g + 4 * product.Carbohydrates100g + 9 * product.Fats100g;
            await _context.FoodProducts.AddAsync(product);
            await _context.SaveChangesAsync();

            int maxId = _context.FoodProducts.Max(x => x.Id);
            product = await _context.FoodProducts.FirstOrDefaultAsync(x=> x.Id == maxId);
            FoodProductDtoGet result = _mapper.Map<FoodProductDtoGet>(product);
            return result;
        }
        public async Task<FoodProductDtoGet> UpdateFoodProductAsync(FoodProductDtoForm productForm, int id)
        {
            FoodProduct oldProduct = await _context.FoodProducts.FirstOrDefaultAsync(x=>x.Id==id);
            FoodProduct product = _mapper.Map<FoodProduct>(productForm);
            product.Id = id;
            _context.Entry(oldProduct).State = EntityState.Detached;
            _context.FoodProducts.Update(product);
            await _context.SaveChangesAsync();
            _context.Entry(product).State = EntityState.Modified;

            product = await _context.FoodProducts.FirstOrDefaultAsync(x=>x.Id==id);
            FoodProductDtoGet result = _mapper.Map<FoodProductDtoGet>(product);
            return result;
        }

        public async Task<FoodProductDtoGet> RemoveFoodProductAsync(int id)
        {
            FoodProduct product = await _context.FoodProducts.FirstOrDefaultAsync(x=>x.Id==id);
            _context.Entry(product).State = EntityState.Detached;
            _context.FoodProducts.Remove(product);
            await _context.SaveChangesAsync();
            _context.Entry(product).State = EntityState.Deleted;

            FoodProductDtoGet result = _mapper.Map<FoodProductDtoGet>(product);
            return result;
        }

        public bool Exists(int id)
        {
            return _context.FoodProducts.Any(x=>x.Id==id);
        }
    }
}
