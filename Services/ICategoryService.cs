using RestaurantMVCCodeFirst.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantMVCCodeFirst.Services
{
    public interface ICategoryService  
    {
        Task<IEnumerable<CategoryModel>> GetAllCategoriesAsync();
        Task<CategoryModel> GetCategoryByIdAsync(int categoryId);
        Task AddCategoryAsync(CategoryModel category);
        Task UpdateCategoryAsync(CategoryModel category);
        Task DeleteCategoryAsync(int categoryId);
    }
}
