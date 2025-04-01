using RestaurantMVCCodeFirst.Data;
using RestaurantMVCCodeFirst.Models;
using Microsoft.EntityFrameworkCore;


namespace RestaurantMVCCodeFirst.Services
{
    public class CategoryService: ICategoryService
    {
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CategoryModel>> GetAllCategoriesAsync()
        {
            return await _context.Category.ToListAsync();
        }

        public async Task<CategoryModel> GetCategoryByIdAsync(int categoryId)
        {
            return await _context.Category.FindAsync(categoryId);
        }

        public async Task AddCategoryAsync(CategoryModel category)
        {
            await _context.Category.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCategoryAsync(CategoryModel category)
        {
            _context.Category.Update(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(int categoryId)
        {
            var category = await _context.Category.FindAsync(categoryId);
            if (category != null)
            {
                _context.Category.Remove(category);
                await _context.SaveChangesAsync();
            }
        }
    }
}
